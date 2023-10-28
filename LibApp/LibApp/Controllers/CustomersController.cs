using LibApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibApp.Controllers
{
    public class CustomersController
    {




        public IActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(customer);
        }




        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }   
    }
}
