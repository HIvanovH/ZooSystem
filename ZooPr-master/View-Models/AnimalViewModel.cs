using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zoo.Models;
using Repository.Services;
using Zoo.Services;
using Repository.Models;

namespace Zoo.View_Models
{
    public class AnimalViewModel : ViewModelBase
    {
        private List<Animal> _animals;
        private List<Category> _categories;
        private Category _selectedCategory;
        private Animal _selectedAnimal;
        private DelegateCommand command;
         
        public ICommand SearchAnimals
        {
            get
            {
                return command ?? (command = new DelegateCommand(context =>
                {
                    SearchAnimalAction();
                }));
            }
        }
        public void SearchAnimalAction()
        {
            Animals = SearchForAnimalService.GetSearchForAnimalService().SearchAnimal(SelectedCategory);
        }
        public void FillCombobox()
        {
            Categories = SearchForAnimalCategory.GetSearchForSpecies().SearchSpecies();
        }
        
        public Animal SelectedAnimal
        {
            get { return _selectedAnimal; }
            set
            {
                _selectedAnimal = value;
                OnPropertyChanged(nameof(SelectedAnimal));
            }
        }
        public List<Animal> Animals
        {
            get { return _animals; }
            set
            {
                _animals = value;
                OnPropertyChanged(nameof(Animals));
            }
        }
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged(nameof(SelectedCategory));
            }
        }
        public List<Category> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }
        public AnimalViewModel()
        {
           
            FillCombobox();
        }
    }
}
