using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class SearchForSpecies
    {
        private static readonly SearchForSpecies _searchForSpecies = new SearchForSpecies();
       
        public static SearchForSpecies GetSearchForSpecies()
        {
            return _searchForSpecies;
        }
        private SearchForSpecies()
        {
           
        }
        public List<Category> SearchSpecies()
        {
            var db = new ZooDbContext();
            return db.Category.ToList();
        }
        /*public List<Category> SearchSpecies(Category SCategory)
        {
            var db = new ZooDbContext();
            return db.Category.Where(a => (SCategory != null) ? a.Category.IdCat == SCategory.IdCat : true).ToList();
        }*/
    }
}
