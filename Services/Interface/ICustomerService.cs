using MyBackendApi.Models;
using System.Collections.Generic;
namespace MyBackendApi.Services.Interfaces
{
    public  interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}

