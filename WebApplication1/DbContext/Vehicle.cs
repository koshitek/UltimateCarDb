using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int Year { get; set; }
        public String Model { get; set; }
        public int ManufacturerId { get; set; }
        public int ProductionYear { get; set; }
        public string Trim { get; internal set; }
    }
}