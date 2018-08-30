using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.DatabaseContext;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class HomeController : Controller
    {
        // api/years
        // api/manufacturer
        // api/vehicle/id

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Manufacturers()
        {
            using (var db = new VehicleDBContext())
            {
                var manufacturers = db.Manufacturers.Select(o => o.Name);
                return View(manufacturers.ToList());
            }
        }

        public ActionResult Years(string manufacturer)
        {
            using (var db = new VehicleDBContext())
            {
                ViewBag.manufacturer = manufacturer;
                var ManufacturerId = db.Manufacturers.Where(o => o.Name == manufacturer).First().ManufacturerId;
                var allyears = db.Vehicles.Where(o => o.ManufacturerId == ManufacturerId);
                return View(allyears.Select(o => o.ProductionYear).ToList());
            }
        }

        public ActionResult Models(int year, string manufacturer)
        {
            ViewBag.manufacturer = manufacturer;
            ViewBag.year = year;

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

        public ActionResult Trims (int year, string modelName, string manufacturer)
        {
            ViewBag.manufacturer = manufacturer;
            ViewBag.year = year;
            ViewBag.modelName = modelName;

            var trimsFake = new List<string> {
                "Eddie Bauer",
                "XLT",
                "SportTrac"
            };
            using (var db = new VehicleDBContext())
            {
                return View(trimsFake);
            }
        }

        public ActionResult Lightbulbs(int year, string modelName, string trimName, string manufacturer)
        {
            ViewBag.manufacturer = manufacturer;
            ViewBag.year = year;
            ViewBag.modelName = modelName;
            ViewBag.trimName = trimName;

            var LightbulbsFake = new List<LigthBulb> {
                new LigthBulb {
                    Name = "H7",
                    Position = "Headlight High Beam",
                    Voltage = 12,
                    BulbType = "Halogen",
                    Wattage = 55,
                    OEMPartNumber = "123=2234=33",
                    AmazonLink = "http://amzn.to/2FqYFfv",  },
                new LigthBulb {
                    Name = "578",
                    Position = "Glove Compartment",
                    Voltage = 12,
                    BulbType = "Halogen",
                    Wattage = 5,
                    OEMPartNumber = "123=2234=33",
                    AmazonLink = "http://amzn.to/2FqYFfv",  },
                new LigthBulb {
                    Name = "168",
                    Position = "License Plate",
                    Voltage = 12,
                    BulbType = "Halogen",
                    Wattage = 5,
                    OEMPartNumber = "123=2234=33",
                    AmazonLink = "http://amzn.to/2FqYFfv",  },
            };
            using (var db = new VehicleDBContext())
            {
                return View(LightbulbsFake);
            }
        }
                
    }
}
