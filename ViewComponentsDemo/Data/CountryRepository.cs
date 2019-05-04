using System.Collections.Generic;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Data
{
    public class CountryRepository : ICountryRepository
    {
        private readonly List<Country> _countries = new List<Country>
        {
            new Country
            {
                Name = "Switzerland",
                Population = 8000
            },
            new Country
            {
                Name = "Austria",
                Population = 9000
            }
        };

        public IEnumerable<Country> Countries()
        {
            return _countries;
        }

        public void AddCountry(Country country)
        {
            _countries.Add(country);
        }
    }
}