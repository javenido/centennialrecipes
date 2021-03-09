using CentennialRecipes.Models;
using CentennialRecipes.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeRepository repository;
        private IChefRepository chefRepository;
        private UserManager<IdentityUser> userManager; // used by RecipeList action

        private const int PAGE_SIZE = 3; // max number of items displayed in a page

        public RecipeController(IRecipeRepository repo,
            IChefRepository repo2,
            UserManager<IdentityUser> usrMgr)
        {
            repository = repo;
            chefRepository = repo2;
            userManager = usrMgr;
        }

        /*
         * This method is called when the cancel button on EnterRecipeDetails view is clicked.
         */
        public IActionResult Cancel(string returnUrl)
        {
            if (returnUrl.Contains("/Recipe/EnterRecipeDetails"))
            {
                returnUrl = "RecipeList";
            }
            return Redirect(returnUrl ?? "/");
        }

        [Authorize(Roles = "Admin,User")]
        public IActionResult DeleteRecipe(int id)
        {
            // retrieve recipe being deleted
            Recipe deletedRecipe = repository.Recipes.FirstOrDefault(r => r.RecipeId == id);

            // check if user is authorized to delete the recipe
            if (User.IsInRole("User") && User.Identity.Name != deletedRecipe.User)
            {
                TempData["message"] = "You do not have permission to delete this recipe.";
                return RedirectToAction("Index", "Home");
            }

            // delete recipe from the database
            deletedRecipe = repository.DeleteRecipe(id);

            // set up alert message
            if (deletedRecipe != null)
                TempData["message"] = $"\"{deletedRecipe.Name}\" was successfully deleted.";
            else
                TempData["message"] = "No recipe deleted.";

            // if request came from Admin/RecipeList (i.e., admin was managing recipes), redirect back
            string referer = HttpContext.Request.Headers["referer"];
            if (referer.Contains("Admin/RecipeList"))
                return RedirectToAction("RecipeList", "Admin");

            // otherwise, return to RecipeList
            return RedirectToAction("RecipeList");
        }

        [Authorize(Roles = "Admin,User")]
        public IActionResult DeleteReview(int id, int recipeId)
        {
            RecipeReview deletedReview = repository.DeleteReview(id);

            // set up alert message
            if (deletedReview != null)
                TempData["message"] = "Review was successfully deleted.";
            else
                TempData["message"] = "No review deleted.";

            return RedirectToAction("ViewRecipe", new { id = recipeId });
        }

        [HttpGet]
        [Authorize(Roles = "Admin,User")]
        public IActionResult EnterRecipeDetails(int id, string returnUrl)
        {
            // instatiate view model
            RecipeViewModel model = new RecipeViewModel
            {
                ReturnUrl = returnUrl
            };

            // check mode (add or edit)
            if (id == 0) // user is adding a new recipe
            {
                model.Recipe = new Recipe() { User = User.Identity.Name };
            }
            else // user is editing an existing recipe
            {
                // retrieve recipe from repository
                Recipe recipe = repository.Recipes.FirstOrDefault(r => r.RecipeId == id);

                // if recipe not found, redirect to home page
                if (recipe == null)
                {
                    TempData["message"] = "Recipe not found.";
                    return RedirectToAction("Index", "Home");
                }

                model.Recipe = recipe;

                // check if user is allowed to edit recipe
                if (User.IsInRole("User") && User.Identity.Name != recipe.User)
                {
                    TempData["message"] = "You do not have permission to edit this recipe.";
                    return Redirect(returnUrl ?? "/"); /* TODO: if returnUrl null, go to Home/Menu */
                }
            }

            // pass chefs to the add/edit recipe form so the chef dropdown can be populated
            ViewBag.Chefs = chefRepository.Chefs.Where(c => c.ChefId != 1).OrderBy(c => c.FirstName);

            // load page
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,User")]
        public IActionResult EnterRecipeDetails(RecipeViewModel model)
        {
            Recipe recipe = model.Recipe;

            // in case model state is invalid, reset the viewbag
            ViewBag.Chefs = chefRepository.Chefs.Where(c => c.ChefId != 1).OrderBy(c => c.FirstName);


            // selected dropdown item is the first option (Chef is not specified)
            if (recipe.ChefId == 0)
            {
                ModelState.AddModelError("", "Please specify who created the recipe.");
            }
            else if (recipe.ChefId == 1)
            {
                if (recipe.ChefName == null || recipe.ChefName.Trim().Length == 0)
                    ModelState.AddModelError("", "Please name the chef who created this recipe.");
            }

            if (ModelState.IsValid)
            {
                if (recipe.ChefId != 1)
                    recipe.ChefName = "";

                // set appropriate alert
                TempData["message"] = recipe.RecipeId == 0 ?
                    $"\"{recipe.Name}\" has been successfully added to Centennial Recipes." :
                    $"\"{recipe.Name}\" has been successfully updated.";

                // save recipe
                recipe = repository.SaveRecipe(recipe);

                return RedirectToAction("ViewRecipe", new
                {
                    id = recipe.RecipeId
                });
            }

            return View(model);
        }

        public async Task<IActionResult> RecipeList(int page = 1, int chefId = 0, string user = "")
        {
            // select all recipes
            var allRecipes = repository.Recipes;

            var selectedRecipes = allRecipes;
            string chefName = "";
            string header = "Recipes";

            // if chefId is not 0, select all recipes with the specified chefId
            if (chefId != 0)
            {
                // check if chef exists
                if (!chefRepository.Chefs.Any(c => c.ChefId == chefId))
                {
                    TempData["message"] = "Chef not found.";
                    return RedirectToAction("Index", "Home");
                }
                selectedRecipes = allRecipes.Where(r => r.ChefId == chefId);
                chefName = chefRepository.Chefs.First(c => c.ChefId == chefId).ToString();
                header = $"Recipes by {chefName}";
            }

            // if user is not null, select all recipes added by the specified user
            if (user.Length != 0)
            {
                // check if user exists
                if (await userManager.FindByNameAsync(user) == null)
                {
                    TempData["message"] = "User not found.";
                    return RedirectToAction("Index", "Home");
                }

                // set header according to filter(s) applied
                selectedRecipes = selectedRecipes.Where(r => r.User == user);
                if (chefId == 0)
                    header = $"Recipes added by {(User.Identity.Name == user ? "You" : user)}";
                else if (chefId == 1)
                    header = $"Other Recipes added by {(User.Identity.Name == user ? "You" : user)}";
                else
                    header = $"{chefName} Recipes added by {(User.Identity.Name == user ? "You" : user)}";
            }

            // set the chef and review count for each of selected recipes
            foreach (Recipe recipe in selectedRecipes)
            {
                recipe.Chef = chefRepository.Chefs.First(c => c.ChefId == recipe.ChefId);
                recipe.SetReviewCount(repository.RecipeReviews.Count(r => r.RecipeId == recipe.RecipeId));
            }

            // if there are no selected recipes
            if (selectedRecipes.Count() == 0)
            {
                ViewBag.NoItemsFound = "No recipes found.";

                if (chefId != 0)
                    ViewBag.NoItemsFound = $"No recipes created by this chef found.";

                if (user.Length != 0)
                {
                    ViewBag.NoItemsFound = $"{(User.Identity.Name == user ? "You have" : "This user has")}" +
                        $" not added any recipe.";
                }

                if (chefId != 0 && user.Length != 0)
                {
                    ViewBag.NoItemsFound = $"{(User.Identity.Name == user ? "You have" : "This user has")}" +
                        $" not added any recipe created by this chef.";
                }
            }

            // instantiate view model
            RecipeListViewModel model = new RecipeListViewModel(selectedRecipes
                .OrderByDescending(r => r.RecipeId)) // order recipes such that the latest recipe added appears first
            {
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PAGE_SIZE,
                    CurrentPage = page,
                    TotalItems = selectedRecipes.Count()
                },
                ChefId = chefId,
                UserName = user
            };

            ViewBag.Header = header;
            ViewBag.Results = $"Displaying {model.RecipeList.Count()} out of {model.PagingInfo.TotalItems} matching result(s)";

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,User")]
        public IActionResult ReviewRecipe(int id)
        {
            // if recipe not found, allow user to select which recipe to review via select input (dropdown)
            if (id == 0)
            {
                ViewBag.Recipes = repository.Recipes.OrderBy(r => r.Name); // pass selection of recipes (sorted alphabetically)
            }
            else
            {
                // retrieve recipe from repository
                Recipe recipe = repository.Recipes.FirstOrDefault(r => r.RecipeId == id);
                if (recipe == null)
                {
                    TempData["message"] = "Recipe not found.";
                    return RedirectToAction("Index", "Home");
                }
                TempData["RecipeName"] = recipe.Name; // pass recipe name via TempData (unreachable if recipe not found)
            }

            return View(new RecipeReview // instantiate view model
            {
                RecipeId = id, // set the recipe ID of this review
                User = User.Identity.Name // set the name of reviewer
            });
        }

        [HttpPost]
        [Authorize(Roles = "Admin,User")]
        public IActionResult ReviewRecipe(RecipeReview review)
        {
            if (ModelState.IsValid && review.RecipeId != 0)
            {
                review.DateAdded = DateTime.Now; // set the date of the review
                repository.SaveReview(review);
                TempData["message"] = "Your review has been successfully added. Thanks for the feedback.";

                // redirect to details page of the recipe that was reviewed so user can see the new entry
                return RedirectToAction("ViewRecipe", new { id = review.RecipeId });
            }

            // reset TempData["RecipeName"]/ViewBag.Recipes if model state is invalid
            if (review.RecipeId == 0)
            {
                ModelState.AddModelError("", "Please select a recipe to review.");
                ViewBag.Recipes = repository.Recipes.OrderBy(r => r.Name);
            }
            else
                TempData["RecipeName"] = repository.Recipes.FirstOrDefault(r => r.RecipeId == review.RecipeId).Name;

            return View(review);
        }

        public IActionResult ViewRecipe(int id)
        {
            // retrieve recipe from repository
            Recipe recipe = repository.Recipes.FirstOrDefault(r => r.RecipeId == id);

            // if recipe not found, redirect to home page
            if (recipe == null)
            {
                TempData["message"] = "Recipe not found.";
                return RedirectToAction("Index", "Home");
            }

            // otherwise, set the recipe's Chef and Review properties
            recipe.Chef = chefRepository.Chefs
                .First(c => c.ChefId == recipe.ChefId);
            recipe.Reviews = repository.RecipeReviews
                .Where((review) => review.RecipeId == id)
                .ToList();
            recipe.SetReviewCount(repository.RecipeReviews.Count(r => r.RecipeId == recipe.RecipeId));

            return View(recipe);
        }
    }
}