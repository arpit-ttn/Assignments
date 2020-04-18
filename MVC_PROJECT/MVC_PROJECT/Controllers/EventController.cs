using MVC_PROJECT.Models;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJECT.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index( )
        {
            RacingEntities context = new RacingEntities();
            var emp = context.Cars.ToList();
            return View(emp);
        }
        public ActionResult Index1()
        {
            RacingEntities context = new RacingEntities();
            var emp = context.Races.ToList();
            return View(emp);
        }
    }
}