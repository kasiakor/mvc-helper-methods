using HelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class PeopleController : Controller
    {

        private Person[] personData =
        {
            new Person {FirstName = "John", LastName = "Doe", Role = Role.Admin},
            new Person {FirstName = "Sarah", LastName = "Key", Role = Role.User},
            new Person {FirstName = "Boris", LastName = "Low", Role = Role.Guest},
            new Person {FirstName = "Kate", LastName = "Bush", Role = Role.User}
        };
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        //a synchronous form
        //public ActionResult GetPeople()
        //{
        //    return View(personData);
        //}

        //[HttpPost]
        //public ActionResult GetPeople(string selectedRole)
        //{

        //    if (selectedRole == null || selectedRole == "All")
        //    {
        //        return View(personData);
        //    }
        //    else
        //    {
        //        Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
        //        return View(personData.Where(p =>p.Role == selected));
        //    }
        //}


        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<Person> data = personData;
            if(selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return PartialView(data);
        }

        // passes selected value as a string to the view
        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((object)selectedRole);
        }
    }
}