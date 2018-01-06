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
        public Manufacturer Manufacturer { get; set; }
        public List<LigthBulb> LightBulbs { get; set; }
    }
}