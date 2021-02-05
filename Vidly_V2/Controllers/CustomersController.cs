using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_V2.Models;

namespace Vidly_V2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Name = "Elliot Hannah", Id = 1},
                new Customer {Name = "Roscoe Jenkins", Id = 2},
                new Customer {Name = "Jim Jones", Id = 3},
                new Customer {Name = "El Chapo, Jr.", Id = 4}
            };
        }
    }
}