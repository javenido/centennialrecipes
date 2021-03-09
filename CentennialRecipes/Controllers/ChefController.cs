using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentennialRecipes.Models;
using CentennialRecipes.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CentennialRecipes.Controllers
{
    public class ChefController : Controller
    {
        private IChefRepository repository;
        private IRecipeRepository recipeRepository;

        private const int PAGE_SIZE = 3; // max number of items displayed in a page

        public ChefController(IChefRepository repo, IRecipeRepository repo2)
        {
            repository = repo;
            recipeRepository = repo2;
        }

        public ViewResult ChefList(Cuisine? cuisine, int page = 1)
        {
            // retrieve all chefs
            var allChefs = repository.Chefs;

            var selectedChefs = allChefs.Where(c => c.ChefId > 1); // exclude default chef
            string header = "Chefs";

            // if cuisine is not null, select all chefs that specializes in the specified cuisine
            if (cuisine != null)
            {
                selectedChefs = selectedChefs.Where(c => c.Specialty == cuisine);
                header = $"{cuisine} Cuisine Chefs";
            }

            // set recipe count (how many recipes are created by the chef) for each chef
            foreach (Chef chef in selectedChefs)
            {
                chef.SetRecipeCount(recipeRepository.Recipes
                    .Where(r => r.ChefId == chef.ChefId).Count());
            }

            // if there are no selected chefs
            if (selectedChefs.Count() == 0)
            {
                if (cuisine != null)
                    ViewBag.NoItemsFound = $"There are no chefs specializing in this cuisine.";
                else
                    ViewBag.NoItemsFound = $"No chefs found.";
            }

            // instantiate the view model
            ChefListViewModel model = new ChefListViewModel(selectedChefs
                .OrderBy(c => c.ToString())) // order chefs alphabetically
            {
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PAGE_SIZE,
                    TotalItems = selectedChefs.Count()
                }
            };

            model.Cuisine = cuisine;
            ViewBag.Header = header;
            ViewBag.Results = $"Displaying {model.ChefList.Count()} out of {model.PagingInfo.TotalItems} matching result(s)";

            return View(model);
        }

        public IActionResult ViewChef(int id)
        {
            Chef chef = repository.Chefs.FirstOrDefault(c => c.ChefId == id);

            // if recipe not found, redirect to home page
            if (chef == null)
            {
                TempData["message"] = "Chef not found.";
                return RedirectToAction("Index", "Home");
            }

            return View(chef);
        }
    }
}