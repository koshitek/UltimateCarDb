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
        // api/years
        // api/manufacturer
        // api/vehicle/id

        public ActionResult Index()
        {
            using (var db = new VehicleDBContext())
            {
                var manufacturers = db.Manufacturers;
                return View(manufacturers.ToList());
            }
        }
        public ActionResult Years()
        {
            // get all years that have vehicles in it.
            using (var db = new VehicleDBContext())
            {
                var vehiclesYears = db.Vehicles.Select(s => s.ProductionYear).Distinct().ToList();
                var distinctYears = db.ProductionYears.Where(s => vehiclesYears.Contains(s.ProductionYearId));
                return View(distinctYears.ToList());
            }
        }
    }
}
