using System.Web.Mvc;
using HelperMethods.Models;

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

        //renders the form
        public ActionResult CreatePerson()
        {
            return View(new Person());
        }

        //data from the form redisplayed to the user
        [HttpPost]
        public ActionResult CreatePerson(Person person)
        {
            return View("DisplayPerson", person);
        }

        public ActionResult CreatePersonAddressObject()
        {
            return View(new Person());
        }

        //data from the form redisplayed to the user
        [HttpPost]
        public ActionResult CreatePersonAddressObject(Person person)
        {
            return View("DisplayPerson", person);
        }
    }
}