using Databasefirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Databasefirst.Controllers
{
    public class CustomerController : Controller
    {

        HOTELEntities h1 = new HOTELEntities();
        // GET: Customer
        public ActionResult Index()
        {
            var data = h1.Customers.ToList();
            return View(data);
        }
        public ActionResult DeleteCustomer(int id)
        {

            var del1 = h1.Customers.Find(id);
            h1.Customers.Remove(del1);
            h1.SaveChanges();
            return RedirectToAction("Index" ,"Customer");
        }

        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer c1)
        {
            h1.Customers.Add(c1);
            h1.SaveChanges();

            return RedirectToAction("Index" ,"Customer");
        }


        public ActionResult EditCustomer(int id)
        {
            if (id == null)
            {
                return Content("ID NULL ahe 😢");
            }

            var data = h1.Customers.Find(id);

            if (data == null)
            {
                return Content("Record not found for ID: " + id);
            }

            return View(data);
        }
        [HttpPost]
        
        public ActionResult EditCustomer(Customer c2)
        {
            var edit = h1.Customers.Find(c2.cid);

            if (edit == null)
            {
                return Content("ID not found");
            }

            edit.cname = c2.cname;
            edit.cemail = c2.cemail;
            edit.cphone = c2.cphone;

            h1.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}