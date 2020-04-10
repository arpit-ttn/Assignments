using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduction_To_MVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
 
        [HttpGet]
        public ActionResult Index()
        {
        ViewBag.MyKey = TempData["Data"];
        return View();
        }
    }
}