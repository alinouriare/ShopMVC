using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.Controllers
{
    public class EmailSendController : Controller
    {
        // GET: EmailSend
        public ActionResult ActiveUser()
        {
            return PartialView();
        }
    }
}