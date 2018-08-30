using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.DatabaseContext;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class CatalogController : Controller
    {
        public ActionResult Years(int manufacturerId)
        {
            using (var db = new VehicleDBContext())
            {
                ViewBag.ManufacturerName = db.Manufacturers.FirstOrDefault(o => o.ManufacturerId == manufacturerId).Name;
                var allyears = db.Vehicles.Where(o => o.ManufacturerId == manufacturerId);
                return View(allyears.Select(o => o.ProductionYear).ToList());
            }
        }

        public ActionResult Models(int year, string model)
        {
            var modelsFake = new List<string> {
                "Explorer",
                "Taurus",
                "Focus"
            };
            using (var db = new VehicleDBContext())
            {
                return View(modelsFake);
            }
        }
    }
}
