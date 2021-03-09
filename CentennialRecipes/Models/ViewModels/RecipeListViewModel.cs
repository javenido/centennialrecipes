using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models.ViewModels
{
    /*
     * Model class for Recipe/RecipeList and Admin/RecipeList views
     */
    public class RecipeListViewModel
    {
        private IQueryable<Recipe> recipes;

        public IEnumerable<Recipe> RecipeList =>
            recipes.Skip((PagingInfo.CurrentPage - 1) * PagingInfo.ItemsPerPage)
                .Take(PagingInfo.ItemsPerPage);

        public PagingInfo PagingInfo { get; set; }

        public int ChefId { get; set; } = 0; // used to filter recipe list according to the chef

        public string UserName { get; set; } // used to filter recipe list according to author

        public RecipeListViewModel(IQueryable<Recipe> recipes)
        {
            this.recipes = recipes;
        }
    }
}