using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.DatabaseContext;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new VehicleDBContext())
            {
                var manufacturers = db.Manufacturers;
                return View(manufacturers.ToList());
            }
        }

    }
}
