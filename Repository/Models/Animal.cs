﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Animal
    {
        
       
        public Animal()
        {

        }
        public Animal(string name, string description, byte[] picture, int categoryId)
        {
            
            Name = name;
            Description = description;
            Picture = picture;
            CategoryId = categoryId;
        }

        [Key]
        
        public int Id { get;set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

       

    }
}
