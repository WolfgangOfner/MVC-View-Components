using System.Collections.Generic;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Data
{
    public interface ICountryRepository
    {
        IEnumerable<Country> Countries();

        void AddCountry(Country country);
    }
}