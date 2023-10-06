using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
internal class CustomerManager : ICustomerService
{
    private IUserValidationService _userValidationService;

    public CustomerManager(IUserValidationService userValidationService)
    {
        _userValidationService = userValidationService;
    }

    public void Add(Customer customer)
    {
        Console.WriteLine(customer.FirstName + " " + customer.LastName + " Added.");
    }

    public void Delete(Customer customer)
    {
        Console.WriteLine(customer.FirstName + " " + customer.LastName + " Deleted.");
    }

    public void Update(Customer customer)
    {
        Console.WriteLine(customer.FirstName + " " + customer.LastName + " Updated.");
    }
}
