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


namespace Zoo.View_Models
{
    public class AnimalViewModel : ViewModelBase
    {
        //private ZooDbContext zooDbContext = new ZooDbContext();
        private List<AnimalToDisplay> _animals;
        private List<SpeciesToDisplay> _categories;
        private SpeciesToDisplay _sCategory;
        private AnimalToDisplay _sAnimal;
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
            Animals = WrapAnimalService.GetWrapAnimalService().WrapAnimalToDisplay();
        }
        public void FillCombobox()
        {
            Categories = WrapSpecies.GetWrapSpecies().WrapWrapSpecies();
        }
        
        public AnimalToDisplay SAnimal
        {
            get { return _sAnimal; }
            set
            {
                _sAnimal = value;
                OnPropertyChanged("SAnimal");
            }
        }
        public List<AnimalToDisplay> Animals
        {
            get { return _animals; }
            set
            {
                _animals = value;
                OnPropertyChanged("Animals");
            }
        }
        public SpeciesToDisplay SCategory
        {
            get { return _sCategory; }
            set
            {
                _sCategory = value;
                OnPropertyChanged("SCategory");
            }
        }
        public List<SpeciesToDisplay> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                OnPropertyChanged("Category");
            }
        }
        public AnimalViewModel()
        {
           
            FillCombobox();
        }
    }
}
