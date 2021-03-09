using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public class Chef
    {
        [Required]
        public int ChefId { get; set; }

        [Required(ErrorMessage = "Enter the chef's first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter the chef's last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Provide a brief description of the chef.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Specify the chef's specialty.")]
        public Cuisine Specialty { get; set; }

        public string Website { get; set; }

        public string Restaurant { get; set; }

        /* THE FOLLOWING METHODS ARE USED BY VIEW MODELS */
        public override string ToString() => $"{FirstName} {LastName}";

        private int recipeCount;
        public void SetRecipeCount(int count) => recipeCount = count;
        public int GetRecipeCount() => recipeCount;
    }

    public enum Cuisine
    {
        American, Brazilian, British, Canadian, Caribbean,
        Chinese, Filipino, French, Greek, Indian,
        Italian, Jamaican, Japanese, Korean, Mediterranean,
        Mexican, Moroccan, Nigerian, Spanish, Swedish,
        Swiss, Thai, Turkish, Vietnamese, Other
    }
}