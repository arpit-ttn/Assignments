using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduction_To_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult Ques1()
        {
            return View();
        }
        public ActionResult Ques2()
        {
            return View();
        }

        // GET: Home
        [HttpGet]
        public ActionResult Ques3()
        {
            ViewBag.Name = "This string is coming from Controller to View using ViewBag";
            ViewBag.Property = "Below is a List of Names (using ViewData) : ";
            ViewData["MyList"] = new List<string>() { "Arpit", "Azeem", "Neha", "Shagun" };
            TempData["Data"] = "Data from Home Controler to Data Controller using Temp Data";
            return View();
        }


        [HttpPost]
        public string UsingRequest()
        {
            try
            {
                string first = Request["Firstname"];
                string last = Request["Lastname"];
                return "From request : " + first + " , " + last;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public ActionResult Ques4()
        {
            return View();
        }
        public ActionResult Ques5()
        {
            return View();
        }
    }
}