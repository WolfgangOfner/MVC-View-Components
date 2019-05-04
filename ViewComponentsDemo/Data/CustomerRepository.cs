using System.Collections.Generic;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer
            {
                Name = "John",
                Age = 30
            },
            new Customer
            {
                Name = "Jane",
                Age = 20
            }
        };

        public IEnumerable<Customer> Customers()
        {
            return _customers;
        }

        public void AddCustomers(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}