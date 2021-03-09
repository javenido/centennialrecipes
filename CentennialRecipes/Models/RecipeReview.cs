using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public class RecipeReview
    {
        [Required]
        public int RecipeReviewId { get; set; }

        [Required(ErrorMessage = "Please select a recipe to review.")]
        public int RecipeId { get; set; }

        [Required(ErrorMessage = "A recipe review cannot be empty.")]
        public string Content { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
    }
}