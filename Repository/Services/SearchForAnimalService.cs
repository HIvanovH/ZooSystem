using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class SearchForAnimalService : BaseService
    {
        private static readonly SearchForAnimalService _searchForAnimalService = new SearchForAnimalService();
        public static SearchForAnimalService GetSearchForAnimalService()
        {
            return _searchForAnimalService;
        }

        public List<Animal> SearchAnimal()
        {
            return _db.Animal.ToList(); 
        }
        public List<Animal> SearchAnimal(Category SCategory)
        {
            return _db.Animal.Where(a=>a.Category==SCategory).ToList();
        }

    }
}
