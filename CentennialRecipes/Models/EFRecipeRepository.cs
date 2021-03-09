using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public IQueryable<RecipeReview> RecipeReviews => context.RecipeReviews;

        public Recipe DeleteRecipe(int recipeId)
        {
            Recipe recipeEntry = context.Recipes
                .FirstOrDefault(r => r.RecipeId == recipeId);

            if (recipeEntry != null)
            {
                context.RecipeReviews.RemoveRange(context.RecipeReviews
                    .Where(r => r.RecipeId == recipeId)); // delete all reviews submitted to this recipe
                context.Recipes.Remove(recipeEntry);
                context.SaveChanges();
            }

            return recipeEntry;
        }

        public RecipeReview DeleteReview(int recipeReviewId)
        {
            RecipeReview reviewEntry = context.RecipeReviews
                .FirstOrDefault(r => r.RecipeReviewId == recipeReviewId);

            if (reviewEntry != null)
            {
                context.RecipeReviews.Remove(reviewEntry);
                context.SaveChanges();
            }

            return reviewEntry;
        }

        public Recipe SaveRecipe(Recipe recipe)
        {
            Recipe newRecipe;
            if (recipe.RecipeId == 0)
            {
                recipe.Name = char.ToUpper(recipe.Name[0]) + recipe.Name.Substring(1);
                newRecipe = context.Recipes.Add(recipe).Entity;
            }
            else
            {
                newRecipe = context.Recipes
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);

                if (newRecipe != null)
                {
                    newRecipe.Name = char.ToUpper(recipe.Name[0]) + recipe.Name.Substring(1);
                    newRecipe.Description = recipe.Description;
                    newRecipe.ChefId = recipe.ChefId;
                    newRecipe.ChefName = recipe.ChefName;
                    newRecipe.PreparationTime = recipe.PreparationTime;
                    newRecipe.Ingredients = recipe.Ingredients;
                }
            }

            context.SaveChanges();
            return newRecipe;
        }

        public void SaveReview(RecipeReview review)
        {
            if (review.RecipeReviewId == 0)
            {
                context.RecipeReviews.Add(review);
            }
            context.SaveChanges();
        }
    }
}