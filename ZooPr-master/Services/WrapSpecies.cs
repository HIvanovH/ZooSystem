using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using Zoo.Models;

namespace Zoo.Services
{
    internal class WrapSpecies
    {
        private static readonly WrapSpecies _wrapSpecies = new WrapSpecies();
        public static WrapSpecies GetWrapSpecies()
        {
            return _wrapSpecies;
        }
        private WrapSpecies()
        {

        }
        public List<SpeciesToDisplay> WrapWrapSpecies()
        {
            List<Repository.Models.Category> categories = SearchForSpecies.GetSearchForSpecies().SearchSpecies();
            List<SpeciesToDisplay> result = new List<SpeciesToDisplay>();

            foreach (Repository.Models.Category category in categories)
            {
                result.Add(new SpeciesToDisplay(category));
            }
            return result;
        }
    }
}
