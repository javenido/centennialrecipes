using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models.ViewModels
{
    public class ChefListViewModel
    {
        private IQueryable<Chef> chefs;

        public PagingInfo PagingInfo { get; set; }

        public IEnumerable<Chef> ChefList =>
            chefs.Skip((PagingInfo.CurrentPage - 1) * PagingInfo.ItemsPerPage)
            .Take(PagingInfo.ItemsPerPage);

        public ChefListViewModel(IQueryable<Chef> chefs)
        {
            this.chefs = chefs;
        }

        public Cuisine? Cuisine { get; set; } // used to filter chefs according to specialty cuisine
    }
}