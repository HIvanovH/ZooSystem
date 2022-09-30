using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Models
{
    public class AnimalToDisplay
    {
        //used when displaying animal in animal view 
        public AnimalToDisplay(Animal animal)
        {
            Name = animal.Name;
            Description = animal.Description;
            Image = animal.Picture;
            Category = animal.Category.Name;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Category { get; set; }
    }
}
