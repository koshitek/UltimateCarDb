using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DatabaseContext
{
    class VehicleDBContext : DbContext
    {
        public VehicleDBContext() : base("VehicleDB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<VehicleDBContext>());
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}