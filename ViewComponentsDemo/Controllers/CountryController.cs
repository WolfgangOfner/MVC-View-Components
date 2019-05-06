using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using ViewComponentsDemo.Data;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Controllers
{
    [ViewComponent(Name = "HybridComponent")]
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            _countryRepository.AddCountry(country);

            return View("Index", "Home");
        }

        public IViewComponentResult Invoke()
        {
            return new ViewViewComponentResult()
            {
                ViewData = new ViewDataDictionary<IEnumerable<Country>>(ViewData,
                _countryRepository.Countries())
            };
        }
    }
}