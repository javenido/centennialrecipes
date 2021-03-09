using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }
        IQueryable<RecipeReview> RecipeReviews { get; }

        Recipe SaveRecipe(Recipe recipe);

        void SaveReview(RecipeReview review);

        Recipe DeleteRecipe(int recipeId);

        RecipeReview DeleteReview(int recipeReviewId);
    }
}
