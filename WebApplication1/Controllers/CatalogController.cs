using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.DatabaseContext;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CatalogController : Controller
    {
        // api/years
        // api/years?manufacturer=id
        // api/manufacturer
        // api/manufacturer?year=id
        // api/vehicle/id
        //https://simpletire.com/catalog?year=2015&make=Toyota&model=Highlander&option=Limited&zip=98230&sort=bestseller&query=catalog
        //catalog
        //    ?year=2015
        //    &make=Toyota
        //    &model=Highlander
        //    &option=Limited
        //    &zip=98230
        //    &sort=bestseller
        //    &query=catalog
         public ActionResult Years()
        {
            using (var db = new VehicleDBContext())
            {
                var years = db.Vehicles
                    .Select(s => s.ProductionYear)
                    .Distinct()
                    .Select(s=>s.Name)
                    .ToList();
                return View(years);
            }
        }
        public ActionResult Manufacturers(string year)
        {
            ViewBag.year = year;

            using (var db = new VehicleDBContext())
            {
                var manufacturerName = db.Vehicles
                    .Where(s=>s.ProductionYear.Name == year)
                    .Select(d=>d.Manufacturer)
                    .Select(s => s.Name)
                    .ToList();
                return View(manufacturerName);
            }
        }
        public ActionResult Models(string year, string manufacturer)
        {
            ViewBag.year = year;
            ViewBag.manufacturer = manufacturer;
            using (var db = new VehicleDBContext())
            {
                var vehiclesModels = db.Vehicles
                    .Where(s => s.ProductionYear.Name == year)
                    .Where(s => s.Manufacturer.Name == manufacturer)
                    .Select(s => s.Model.Name)
                    .Distinct()
                    .ToList();
                return View(vehiclesModels);
            }
        }
        public ActionResult Trims (string year, string manufacturer, string model)
        {
            ViewBag.year = year;
            ViewBag.manufacturer = manufacturer;
            ViewBag.model = model;
            using (var db = new VehicleDBContext())
            {
                var allTrims = db.Vehicles
                     .Where(s => s.ProductionYear.Name == year)
                     .Where(s => s.Manufacturer.Name == manufacturer)
                     .Where(s => s.Model.Name == model)
                     .Select(s => s.Trim.Name)
                     .Distinct()
                     .ToList();
                return View(allTrims);
            }
        }
        public ActionResult Lightbulbs(string year, string model, string trim, string manufacturer)
        {
            ViewBag.year = year;
            ViewBag.manufacturer = manufacturer;
            ViewBag.model = model;
            ViewBag.trim= trim;

            using (var db = new VehicleDBContext())
            {
                var allLightbulbs = db.Vehicles
                     .Where(s => s.ProductionYear.Name == year)
                     .Where(s => s.Manufacturer.Name == manufacturer)
                     .Where(s => s.Model.Name == model)
                     .Where(s => s.Trim.Name == trim)
                     .First().LigthBulbCarSpecific;
                string output = JsonConvert.SerializeObject(allLightbulbs);
                
                return View();
            }
        }
                
    }
}
