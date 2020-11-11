using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruit = new string[] { "Pear","Plum","Pomelo"};
            ViewBag.Cities = new string[] { "Berlin", "Vienna", "Innsbruck" };
            string message = "This is my html element <input>";
            return View((object)message);
        }
    }
}