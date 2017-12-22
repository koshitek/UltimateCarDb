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
            AddVehicles();
            return View();
        }

        public void AddVehicles()
        {
            using (var db = new VehicleDBContext())
            {
                var vehicle = new Vehicle { Name = "MyfirstVehicle" };
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
            }
        }
    }
}
