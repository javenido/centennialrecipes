using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentennialRecipes.Models;
using CentennialRecipes.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace CentennialRecipes.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IRecipeRepository recipeRepository;
        private IChefRepository chefRepository;
        private UserManager<IdentityUser> userManager; // used by RecipeList action

        private const int PAGE_SIZE = 8; // max number of items displayed in a page

        public AdminController(IRecipeRepository repo1,
            IChefRepository repo2,
            UserManager<IdentityUser> usrMgr)
        {
            recipeRepository = repo1;
            chefRepository = repo2;
            userManager = usrMgr;
        }

        /*
         * This method is called when the cancel button on EnterChefDetails view is clicked.
         */
        public IActionResult Cancel(string returnUrl)
        {
            if (returnUrl.Contains("/Admin/EnterChefDetails"))
            {
                returnUrl = "ChefList";
            }
            return Redirect(returnUrl ?? "/");
        }

        public ViewResult ChefList(int page = 1)
        {
            // retrieve all chefs
            var selectedChefs = chefRepository.Chefs.Where(c => c.ChefId > 1); // exclude default chef
            string header = "Displaying all chefs";

            // set recipe count (how many recipes are created by the chef) for each chef
            foreach (Chef chef in selectedChefs)
            {
                chef.SetRecipeCount(recipeRepository.Recipes
                    .Where(r => r.ChefId == chef.ChefId).Count());
            }

            // if there are no selected chefs
            if (selectedChefs.Count() == 0)
                ViewBag.NoItemsFound = $"No chefs found.";

            // instantiate the view model
            ChefListViewModel model = new ChefListViewModel(selectedChefs)
            {
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PAGE_SIZE,
                    TotalItems = selectedChefs.Count()
                }
            };

            ViewBag.Header = header;
            ViewBag.Results = $"Displaying {model.ChefList.Count()} out of {model.PagingInfo.TotalItems} matching result(s)";

            return View(model);
        }

        public IActionResult DeleteChef(int id)
        {
            // don't allow deletion of default "unknown" chef
            if (id == 1)
            {
                TempData["message"] = "Access denied. This chef cannot be deleted";
                return RedirectToAction("Index", "Home");
            }

            Chef deletedChef = chefRepository.Chefs.FirstOrDefault(c => c.ChefId == id);

            deletedChef = chefRepository.DeleteChef(id);

            if (deletedChef != null)
            {
                TempData["message"] = $"Chef {deletedChef.ToString()} was successfully deleted.";
            }
            else
            {
                TempData["message"] = "No chef deleted.";
            }

            return RedirectToAction("ChefList");
        }

        [HttpGet]
        public IActionResult EnterChefDetails(int id = 0, string returnUrl = "ChefList")
        {
            Chef chef;

            // if Admin is creating a new chef
            if (id == 0) { chef = new Chef() { Specialty = Cuisine.Other }; }

            // don't allow update on default "unknown" chef
            else if (id == 1)
            {
                TempData["message"] = "Access denied. This chef cannot be updated.";
                return Redirect(returnUrl ?? "/");
            }

            // if Admin is updating an existing chef
            else { chef = chefRepository.Chefs.FirstOrDefault(c => c.ChefId == id); }

            return View(new ChefViewModel { Chef = chef, ReturnUrl = returnUrl });
        }

        [HttpPost]
        public IActionResult EnterChefDetails(ChefViewModel model)
        {
            Chef chef = model.Chef;

            if (ModelState.IsValid)
            {
                // check if the provided website URL is invalid
                if (chef.Website != null && chef.Website != "")
                {
                    Uri uriResult;
                    bool result = Uri.TryCreate(chef.Website, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                    if (!result) // if website URL provided is invalid, don't save and redirect user to form
                    {
                        ModelState.AddModelError("", "Invalid website URL provided"); // add appropriate error message
                        return View(model);
                    }
                }

                // set appropriate alert
                if (model.Chef.ChefId == 0)
                    TempData["message"] = $"Chef {chef.ToString()} has been successfully added.";
                else
                    TempData["message"] = $"Chef {chef.ToString()} was successfully updated";

                // save chef
                chefRepository.SaveChef(chef);

                return RedirectToAction("ViewChef", "Chef", new { id = chef.ChefId });
            }

            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RecipeList(int page = 1, int chefId = 0, string user = "")
        {
            // select all recipes
            var allRecipes = recipeRepository.Recipes;

            var selectedRecipes = allRecipes;
            string chefName = "";
            string header = "Displaying all recipes";

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
                header = $"Displaying recipes created by {chefName}";
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
                selectedRecipes = selectedRecipes.Where(r => r.User == user);
                header = $"Displaying recipes added by {user}";
            }

            // if search is by both chef and author
            if (chefId != 0 && user.Length != 0)
                header = $"Displaying all {chefName} recipes added by {user}";

            // set the chef and review count for each of selected recipes
            foreach (Recipe recipe in selectedRecipes)
            {
                recipe.Chef = chefRepository.Chefs.First(c => c.ChefId == recipe.ChefId);
                recipe.SetReviewCount(recipeRepository.RecipeReviews.Count(r => r.RecipeId == recipe.RecipeId));
            }

            // if there are no selected recipes
            if (selectedRecipes.Count() == 0)
            {
                ViewBag.NoItemsFound = "No recipes found.";

                if (chefId != 0)
                    ViewBag.NoItemsFound = "No recipes created by this chef found.";

                if (user.Length != 0)
                    ViewBag.NoItemsFound = "This user has not added any recipe.";

                if (chefId != 0 && user.Length != 0)
                    ViewBag.NoItemsFound = "This user has not added any recipe created by the specified chef.";
            }

            // instantiate view model
            RecipeListViewModel model = new RecipeListViewModel(selectedRecipes)
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
    }
}