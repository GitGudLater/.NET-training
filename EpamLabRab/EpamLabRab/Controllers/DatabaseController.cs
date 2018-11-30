using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpamLabRab.Controllers
{
    public class DatabaseController : Controller
    {
        Models.DataEntityBase mainbase = new Models.DataEntityBase();

        [HttpGet]
        public ActionResult PersonForm()
        {
            Models.PersonDatabase person = new Models.PersonDatabase();
            return View(person);
        }
        [HttpGet]
        public ActionResult DatabseForm()
        {
            return View(mainbase.Persons.ToList());
        }
        [HttpGet]
        public ActionResult Change(string id)
        {
            int _id = Convert.ToInt32(id);
            Models.PersonDatabase person;
            person = (mainbase.Persons.Where(a => a.ID == _id)).SingleOrDefault();
            return View(person);
        }
        [HttpGet]
        public ActionResult DeleteUser(string id)
        {
            int _id = Convert.ToInt32(id);
            Models.PersonDatabase person;
            person = (mainbase.Persons.Where(a => a.ID == _id)).SingleOrDefault();
            return View(person);
        }
        [HttpPost]
        public ActionResult Change(Models.PersonDatabase somePerson)
        {
            if(somePerson!=null && ModelState.IsValid)
            {
                mainbase.Entry(somePerson).State = System.Data.Entity.EntityState.Modified;
                mainbase.SaveChanges();
                return RedirectToAction("DatabseForm", "Database");
            }
            return View(somePerson);
        }
        [HttpPost]
        public ActionResult PersonForm(Models.PersonDatabase person)
        {
            if(ModelState.IsValid)
            {
                mainbase.Persons.Add(person);
                mainbase.SaveChanges();
                person = new Models.PersonDatabase();
                return View(person);
            }
            return View(person);
        }
        [HttpPost]
        public ActionResult DeleteUser(Models.PersonDatabase person)
        {
            mainbase.Persons.Remove(person);
            mainbase.Entry(person).State = System.Data.Entity.EntityState.Deleted;
            mainbase.SaveChanges();
            return RedirectToAction("DatabseForm", "Database");
        }
        [HttpPost]
        public  ActionResult DatabseForm(int id,string name)
        {
            if(name=="Change")
            {
                return RedirectToAction("Change", "Database",new { id = id });
            }
            else
            {
                return RedirectToAction("DeleteUser","Database",new { id = id });
            }
        }
    }
}