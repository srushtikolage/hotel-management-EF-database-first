using Databasefirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Databasefirst.Controllers
{
    public class OrderController : Controller
    {

        HOTELEntities H1 = new HOTELEntities();
        // GET: Order
        public ActionResult Index()
        {
            var data = H1.Orders.ToList();


            return View(data);
        }

        public ActionResult DeleteOrder(int id)
        {
            var del = H1.Orders.Find(id);
            H1.Orders.Remove(del);
            H1.SaveChanges();
            return RedirectToAction("Index", "Order");

        }
        public ActionResult AddOrder()
        {

            return View();

        }

        [HttpPost]
        public ActionResult AddOrder(Order o1)
        {

            H1.Orders.Add(o1);
            H1.SaveChanges();

            TempData["msg"] = "Order Addes Successfully!!!";
            return RedirectToAction("AddOrder");
        }

        public ActionResult EditOrder(int id)
        {

            var data = H1.Orders.Find(id);

            return View(data);
        }
     
        [HttpPost]
        public ActionResult EditOrder(Order o2)
        {
            var edit = H1.Orders.Find(o2.oid);

           

            edit.oname = o2.oname;
            edit.odate = o2.odate;
            edit.qty = o2.qty;
            edit.oprice = o2.oprice;
            edit.ostatus = o2.ostatus;
            edit.custID = o2.custID;
            H1.Orders.AddOrUpdate(edit);
            H1.SaveChanges();

            return RedirectToAction("Index");
        }

    }

    
}