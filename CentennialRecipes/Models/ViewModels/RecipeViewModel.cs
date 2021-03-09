using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models.ViewModels
{
    public class RecipeViewModel
    {
        public Recipe Recipe { get; set; }

        public string ReturnUrl { get; set; }
    }
}