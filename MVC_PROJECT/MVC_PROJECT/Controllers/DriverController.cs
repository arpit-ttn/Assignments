using MVC_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJECT.Controllers
{
   
    public class DriverController : Controller
    {
        // GET: Driver
        [HttpGet]
        public ActionResult Index()
        {

            RacingEntities context = new RacingEntities();
            var emp = context.Drivers.ToList();
            return View(emp);

        }
       
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Driver driver)
        {
            if (ModelState.IsValid)
            {
                RacingEntities context = new RacingEntities();

                context.Drivers.Add(driver);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }
        [Route("Driver/{id}")] //Attribute Routing
        public ActionResult Edit(int? id)
        {
            try
            {

                RacingEntities context = new RacingEntities();
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Driver driver = context.Drivers.Find(id);
                if (driver == null)
                {
                    return HttpNotFound();
                }
                return View(driver);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}