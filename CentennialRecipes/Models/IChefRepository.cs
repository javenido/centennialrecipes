using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public interface IChefRepository
    {
        IQueryable<Chef> Chefs { get; }

        void SaveChef(Chef chef);

        Chef DeleteChef(int chefId);
    }
}
