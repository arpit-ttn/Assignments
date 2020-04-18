using MVC_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJECT.Controllers
{
    public class WinnerController : Controller
    {
        // GET: Winner
        public ActionResult Index()
        {
            RacingEntities context = new RacingEntities();
            var win = context.owns.ToList();
            return View(win);
        }

        public ActionResult Index1()
        {
            RacingEntities context = new RacingEntities();
            var win = context.Participations.ToList();
            return View(win);
        }
    }
}