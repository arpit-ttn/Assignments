using MVC_Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basic.Controllers
{
    public class HomeController : Controller
    {
        readonly IDriver _driver;

        public HomeController()
        {
            _driver = new DriverService();
        }

        // GET: Home
        public ActionResult Index()
        {
            // In this View , I have set the Main_layout so that my header and navbar is inserted on this Home/Index page
            // In this I have used Html.Render and Html.RenderPartial
            return View();
        }
        public ActionResult Ques1()
        {
           
            return View();
        }
        public PartialViewResult OneSubpart()
        {
            return PartialView("_PartialView");
        }
        public ActionResult Ques2()
        {
            return View();
        }
        [NonAction]
        public PartialViewResult NonAction() // it will not be executed anywhere.
        {
            return PartialView("_PartialView");
        }
        [ChildActionOnly]
        public PartialViewResult ChildAction() // this method will be invoked inside any other action
        {                                      // and it cannot be created directly as /home/childaction    
            return PartialView("_PartialView");
        }
        public ActionResult Ques3()
        {
            return View();
        }

       [HttpGet]
        public ActionResult GetDriver()
        {
            var result = GetDriverList();
            return View("GetDriver",result);
        }
        public IEnumerable<Driver> GetDriverList()
        {
            var result = _driver.GetDriver();
            return result;
        }

        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form([Bind(Include = "Driver_id,DriverName,DriverAddress,DriverAge")] Driver driver)
        {                               // this method shows the binding of the 
                                        //we use the “Bind'' attribute in the action parameter
            if (ModelState.IsValid)
            {
                _driver.Save(driver);
                return RedirectToAction("GetDriver");
            }
            return View("Form");
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