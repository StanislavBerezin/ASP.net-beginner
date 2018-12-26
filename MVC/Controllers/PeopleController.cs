using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        // index - actions, from route config
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Stas", LastName = "Berezin", Age = 25 });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Moe", Age = 22 });
            people.Add(new PersonModel { FirstName = "Smith", LastName = "Foe", Age = 23 });

            //here we can pass parameteres to our view
            return View(people);
        }
    }
}