using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DatabaseContext
{
    class VehicleDBContext : DbContext
    {
        public VehicleDBContext() : base("VehicleDB")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<VehicleDBContext>());
        }

        public DbSet<Vehicle> Vehicles
        {
            get;
            set;
        }
    }
}