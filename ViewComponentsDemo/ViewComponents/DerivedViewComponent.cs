using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ViewComponentsDemo.Data;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.ViewComponents
{
    public class DerivedViewComponent : ViewComponent
    {
        private readonly ICountryRepository _countryRepository;

        public DerivedViewComponent(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IViewComponentResult Invoke(bool useParameter)
        {
            if (useParameter)
            {
                return Content("Doing something with the value provided from the parent view");
            }

            var id = RouteData.Values["id"] as string;

            if (!string.IsNullOrWhiteSpace(id))
            {
                return Content($"The entered id is {id}");
            }

            return View(new CountryViewModel
            {
                Countries = _countryRepository.Countries().Count(),
                Population = _countryRepository.Countries().Sum(x => x.Population)
            });
        }
    }
}