using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public class EFChefRepository : IChefRepository
    {
        private ApplicationDbContext context;

        public EFChefRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Chef> Chefs => context.Chefs;

        public void SaveChef(Chef chef)
        {
            if (chef.ChefId == 0)
            {
                context.Chefs.Add(chef);
            }
            else
            {
                Chef chefEntry = context.Chefs
                    .FirstOrDefault(c => c.ChefId == chef.ChefId);

                if (chefEntry != null)
                {
                    chefEntry.FirstName = chef.FirstName;
                    chefEntry.LastName = chef.LastName;
                    chefEntry.Specialty = chef.Specialty;
                    chefEntry.Website = chef.Website;
                    chefEntry.Restaurant = chef.Restaurant;
                }
            }
            context.SaveChanges();
        }

        public Chef DeleteChef(int chefId)
        {
            Chef chefEntry = context.Chefs.FirstOrDefault(c => c.ChefId == chefId);

            if(chefEntry != null && chefId != 1)
            {
                // update all recipes that are created by the deleted chef
                foreach (Recipe recipe in context.Recipes.Where(r => r.ChefId == chefEntry.ChefId))
                {
                    recipe.ChefId = 1; // set chef to default "unknown" chef
                    recipe.ChefName = "Unspecified";
                }

                // perform deletion and update database
                context.Chefs.RemoveRange(context.Chefs
                    .Where(c => c.ChefId == chefId));
                context.Chefs.Remove(chefEntry);
                context.SaveChanges();
            }
            return chefEntry;
        }

    }
}
