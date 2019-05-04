using System.Linq;
using ViewComponentsDemo.Data;

namespace ViewComponentsDemo.ViewComponents
{
    public class PocoViewComponent
    {
        private readonly ICountryRepository _countryRepository;

        public PocoViewComponent(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public string Invoke()
        {
            return $"{_countryRepository.Countries().Count()} counties with a " +
                   $"population of {_countryRepository.Countries().Sum(x => x.Population)}";
        }
    }
}