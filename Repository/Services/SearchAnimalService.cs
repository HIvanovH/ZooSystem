using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class SearchAnimalService 
    {
        public Animal SearchAnimal()
        {
            return   
         
                Animals = (from Animal in zooDbContext.Animal
                           join Category in zooDbContext.Category on Animal.IdCat equals Category.IdCat
                           select new AnimalToDisplay() { Name = Animal.Name, Description = Animal.Description, Image = Animal.Picture, Category = Category.Name }).ToList();
        
            
        }
        public Animal SearchAnimal(Category SCategory)
        {
           
                Animals = (from Animal in zooDbContext.Animal
                           join Category in zooDbContext.Category on Animal.IdCat equals Category.IdCat
                           where Animal.IdCat == SCategory.IdCat
                           select new AnimalToDisplay() { Name = Animal.Name, Description = Animal.Description, Image = Animal.Picture, Category = Category.Name }).ToList();

        }

    }
}
