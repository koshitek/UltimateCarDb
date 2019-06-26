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
            ViewBag.year = year; // 1999
            ViewBag.manufacturer = manufacturer; // ACURA
            ViewBag.model = model; // TL
            ViewBag.trim= trim; // 3.2 V6

            //Select ls.oemPartNumber, p.name, gg.* from Vehicles v
            //inner join Manufacturers m on m.ManufacturerId = v.Manufacturer_ManufacturerId
            //inner join Models mo on mo.ModelId = v.Model_ModelId
            //inner join Trims t on t.TrimId = v.Trim_TrimId
            //inner join LigthBulbCarSpecifics ls on ls.Vehicle_VehicleId = v.VehicleId
            //inner join LigthBulbPositions p on p.LigthBulbPositionId = ls.ligthBulbPositionId_LigthBulbPositionId
            //inner join LigthBulbCarSpecificLightbulbGenerics bb on bb.LigthBulbCarSpecific_LigthBulbCarSpecificId = ls.LigthBulbCarSpecificId
            //inner join LightbulbGenerics gg on gg.LightbulbGenericId = ls.LigthBulbCarSpecificId
            //where ManufacturerId = 2 and ModelId = 1 and TrimId = 1

            using (var db = new VehicleDBContext())
            {
                Vehicle vehicle = db.Vehicles
                    .Include("LigthBulbCarSpecific")
                     .Where(s => s.ProductionYear.Name == year)
                     .Where(s => s.Manufacturer.Name == manufacturer)
                     .Where(s => s.Model.Name == model)
                     .Where(s => s.Trim.Name == trim).FirstOrDefault();
                List<int> searchedId = vehicle.LigthBulbCarSpecific.Select(x => x.LigthBulbCarSpecificId).ToList();
                //var numberFound = vehicle.Count();
                var json = JsonConvert.SerializeObject(searchedId);

                // resolving the position object.
                var resolvingPosition = db.LigthBulbCarSpecific
                     .Where(s => searchedId.Contains(s.LigthBulbCarSpecificId))
                     .Select(s => new { s.ligthBulbPositionId, s.LightbulbGenerics });
                var numberFound22 = searchedId.Count();
                var numberFound222 = resolvingPosition.Count();
                var json3 = JsonConvert.SerializeObject(resolvingPosition);

                // resolving the position object.
                var resolvingPosition2 = db.LigthBulbCarSpecific
                     .Where(s => s.LigthBulbCarSpecificId == 1)
                     .Select(s => new { s.ligthBulbPositionId });
                var json4 = JsonConvert.SerializeObject(resolvingPosition);
                var json5 = "sdfa";


                //                {
                //                    "VehicleId":1,
                //   "ProductionYear":{
                //                        "ProductionYearId":14,
                //      "Name":"2003"
                //   },
                //   "Manufacturer":{
                //                        "ManufacturerId":2,
                //      "Name":"FORD"
                //   },
                //   "Model":{
                //                        "ModelId":1,
                //      "Name":"Explorer"
                //   },
                //   "Trim":{
                //                        "TrimId":1,
                //      "Name":"Eddie Bauer"
                //   },
                //   "LigthBulbCarSpecific":[
                //      {  
                //         "LigthBulbCarSpecificId":1,
                //         "ligthBulbPositionId":null,
                //         "oemPartNumber":"123=2234=33",
                //         "LightbulbGenerics":[
                //         ]
                //    },
                //      {  
                //         "LigthBulbCarSpecificId":2,
                //         "ligthBulbPositionId":null,
                //         "oemPartNumber":"123=2234=33",
                //         "LightbulbGenerics":[
                //         ]
                //},
                //      {  
                //         "LigthBulbCarSpecificId":3,
                //         "ligthBulbPositionId":null,
                //         "oemPartNumber":"123=2234=33",
                //         "LightbulbGenerics":[
                //         ]
                //      }
                //   ]
                //}

                var allLightbulbs = from l in db.Vehicles
                                    where (
                                        l.ProductionYear.Name == "2003"
                                        && l.Manufacturer.Name == "FORD"
                                        && l.Model.Name == "Explorer"
                                        && l.Trim.Name == "Eddie Bauer")
                                    select new
                                    {
                                        l.LigthBulbCarSpecific
                                    };

                return View(allLightbulbs);
            }
        }
                
    }
}
