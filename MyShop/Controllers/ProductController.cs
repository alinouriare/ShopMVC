using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyShop.Models;
using System.Web.Mvc;

namespace MyShop.Controllers
{
    public class ProductController : Controller
    {
        MyEshopEntities database = new MyEshopEntities();
        // GET: Product
        public ActionResult ShowGroup()
        {
            return PartialView(database.Product_Groups.ToList());
        }

        public ActionResult ShowProductByGroup(int id)
        {

            return View(database.Products.Where(p=>p.GroupID == id).ToList());
        }
    }
}