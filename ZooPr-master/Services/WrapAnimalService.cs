using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models;

namespace Zoo.Services
{
    public class WrapAnimalService
    {
        private static readonly WrapAnimalService _wrapAnimalService = new WrapAnimalService();
        public static WrapAnimalService GetWrapAnimalService()
        {
            return _wrapAnimalService;
        }
        private WrapAnimalService()
        {

        }
        public List<AnimalToDisplay> WrapAnimalToDisplay()
        {
            List<Animal> animalList = SearchForAnimalService.GetSearchForAnimalService().SearchAnimal();
            List<AnimalToDisplay> result = new List<AnimalToDisplay>();
            
            foreach (Animal animal in animalList)
            {
                result.Add(new AnimalToDisplay(animal));
            }
            return result;
        }
    }
}
