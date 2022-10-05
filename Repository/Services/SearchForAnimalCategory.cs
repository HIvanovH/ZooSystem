using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class SearchForAnimalCategory
    {
        private static readonly SearchForAnimalCategory _searchForSpecies = new SearchForAnimalCategory();
       
        public static SearchForAnimalCategory GetSearchForSpecies()
        {
            return _searchForSpecies;
        }
        private SearchForAnimalCategory()
        {
           
        }
        public List<Category> SearchSpecies()
        {
            var db = new ZooDbContext();
            return db.Category.ToList();
        }
        
    }
}
