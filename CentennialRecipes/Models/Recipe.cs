using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public class Recipe
    {
        [Required]
        public int RecipeId { get; set; }

        [Required]
        public string User { get; set; }

        [Required(ErrorMessage = "Please enter a name for the recipe.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a brief description of the recipe.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please specify who created the recipe.")]
        public int ChefId { get; set; }

        [Required(ErrorMessage = "Please specify approximately how long it takes to prepare the recipe.")]
        public string PreparationTime { get; set; }

        [Required(ErrorMessage = "Please add at least one ingredient.")]
        public string Ingredients { get; set; }

        /* THE FOLLOWING PROPERTIES/METHODS ARE USED BY VIEW MODELS */
        public Chef Chef { get; set; }
        public string ChefName { get; set; }

        public IEnumerable<string> GetIngredients() => Ingredients.Split(';').ToList()
            .Where((ingredient) => ingredient.Length > 0);

        public List<RecipeReview> Reviews { get; set; }
        private int reviewCount; // number of reviews
        public void SetReviewCount(int count) => reviewCount = count;
        public int GetReviewCount() => reviewCount;
    }
}