using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class SearchForAnimalService
    {
        private static readonly SearchForAnimalService _searchForAnimalService = new SearchForAnimalService();
        public static SearchForAnimalService GetSearchForAnimalService()
        {
            return _searchForAnimalService;
        }
        private SearchForAnimalService()
        {

        }
        public List<Animal> SearchAnimal()
        {
            var db = new ZooDbContext();
            return db.Animal.ToList(); 
        }
        public List<Animal> SearchAnimal(Category SCategory)
        {
            var db = new ZooDbContext();
            return db.Animal.Where(a=> (SCategory!=null)? a.Category.IdCat==SCategory.IdCat : true).ToList();
        }

    }
}
