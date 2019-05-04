using System.Collections.Generic;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Data
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Customers();
        void AddCustomers(Customer customer);
    }
}