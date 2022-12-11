using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using tp3.Models;
using static System.Net.Mime.MediaTypeNames;


namespace tp3.Controllers
{
    public class PersonController : Controller
    {
        // GET: DataBase
        List<Person> persons = new List<Person>();
        PersonalInfo personalInfo = new PersonalInfo();
        Person p1 = new Person();
   
        public ActionResult All()
        {
            {
                persons = personalInfo.GetAllPerson();
                return View(persons);
            }
        }
      
        public ActionResult Afficher(int id)
        {
            Debug.WriteLine(id);

            p1 = personalInfo.GetPersonById(id);
            Debug.WriteLine("p1 detected " + p1.Id);

            return View(p1);

        }
        public ActionResult Search()
        {
            Debug.WriteLine(" form loading");
            return View();
        }


        [HttpPost]
        public ActionResult Search(String name, String country)
        {
            Debug.WriteLine(" form arrived");
            Debug.WriteLine(name + " lives in "+ country);
            PersonalInfo personal_info = new PersonalInfo();
            List<Person> persons = personal_info.GetAllPerson();
            foreach (Person person in persons)
            {
                if (person.FirstName == name && person.Country == country)
                {
                    int id = person.Id;
                    Debug.WriteLine("person's id is " + id);

                    return RedirectToAction("Afficher", new { id = id });

                }
            }
            ViewBag.notFound = true;
            return View();
        }



    } 
}