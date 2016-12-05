using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
     
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(x => x.Id == id);

            if (customers == null)
                return HttpNotFound();

            return View(customers);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Name = "Dushyanth Reddy", Id = 1},
                new Customer {Name = "Abhishek Tadisina", Id = 2}
            };
        }
    }
}