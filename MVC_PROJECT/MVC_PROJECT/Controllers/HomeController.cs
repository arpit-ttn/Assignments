using MVC_PROJECT.Filter;
using MVC_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

      [HandleError(Order =2)]
      [OutputCache(Order =1, Duration =60)]//filter lagaya aur order set kiya
        public ActionResult Ques1()
        {

            return View();
        }
        [PassFilter]
       public ActionResult act()
        {
            return View();
        } 
        public ActionResult Ques2()
        {
            return View();
        }
       
        public ActionResult Ques3()
        {
            return View();
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