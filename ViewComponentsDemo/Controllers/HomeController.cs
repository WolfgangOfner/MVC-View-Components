using Microsoft.AspNetCore.Mvc;
using ViewComponentsDemo.Data;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerRepository _customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            return View(_customerRepository.Customers());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _customerRepository.AddCustomers(customer);

            return RedirectToAction(nameof(Index));
        }
    }
}