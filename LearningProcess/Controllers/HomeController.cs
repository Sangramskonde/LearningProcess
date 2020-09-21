using LearningProcess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningProcess.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Home(HomePage h)
        {
            int a = 10;
            int b = 5;
            int c;
            c = a + b;

            if (h.User != "0")
            {
                if (h.User == "1")
                {
                    return RedirectToAction("Admin");
                }
                else if (h.User == "2")
                {
                    return RedirectToAction("Teacher");
                }
                else if (h.User == "3")
                {
                    return RedirectToAction("Student");
                }

            }
       
            
                return View(h);
            
        }

         public ActionResult Admin()
        {
            
            return View();
        }

        public ActionResult Teacher()
        {

            return View();
        }

         public ActionResult Student()
        {

            return View();
        }

    }
}