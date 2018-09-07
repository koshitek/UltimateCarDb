using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public ProductionYear ProductionYear { get; set; }
        public Manufacturer ManufacturerId { get; set; }
        public Model Model { get; set; }
        public Trim Trim { get; set; }
        public List<LigthBulbCarSpecific> LigthBulbCarSpecific { get; set; }
    }
}