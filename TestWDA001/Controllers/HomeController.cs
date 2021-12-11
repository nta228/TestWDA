using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWDA001.Data;
using TestWDA001.Models;

namespace TestWDA001.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext myDBContext = new MyDBContext();
        public ActionResult Index()
        {
            var result = myDBContext.Students.ToList();
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult List(string name)
        {
            var student = new Student()
            {
                Name = name
            };
            myDBContext.Students.Add(student);
            myDBContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }

   
}