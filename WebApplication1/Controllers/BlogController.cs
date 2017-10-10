using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(contact c)
        {
            using (Model1 b = new Model1())
            {
                b.contacts.Add(c);
                b.SaveChanges();
                return Json(new { success = true, message = "Saved Successfully ya kimo" }, JsonRequestBehavior.AllowGet);
            }
            
            
        }
    }
}