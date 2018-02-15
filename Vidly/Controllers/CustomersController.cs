using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
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
                return HttpNotFound();

            return View(customer);
        }

        public IList<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer(){ Name = "Igor Carlos", Id = 1},
                new Customer(){Name = "Testye da silva", Id = 2}
            };

            return customers;
        }


    }

}