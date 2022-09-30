
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zoo.Models;


namespace Zoo.View_Models
{
    public class AnimalViewModel : ViewModelBase
    {
        //private ZooDbContext zooDbContext = new ZooDbContext();
        private List<AnimalToDisplay> _animals;
        private List<Category> _categories;
        private Category _sCategory;
        private AnimalToDisplay _sAnimal;
        private ICommand _searchAnimals;
        private DelegateCommand loginCommand;
        public ICommand SearchAnimals
        {
            get
            {
                return loginCommand ?? (loginCommand = new DelegateCommand(context =>
                {
                    SearchAnimalAction();
                }));
            }
        }


        public void SearchAnimalAction()
        {

        }
        public void FillCombobox()
        {
          
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
        public Category SCategory
        {
            get { return _sCategory; }
            set
            {
                _sCategory = value;
                OnPropertyChanged("SCategory");
            }
        }
        public List<Category> Categories
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
