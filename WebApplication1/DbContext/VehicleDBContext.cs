using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DatabaseContext
{
    class VehicleDBContext : DbContext
    {
        public VehicleDBContext() : base("Vehicles")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<VehicleDBContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<VehicleDBContext>());
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ProductionYear> ProductionYears { get; set; }
    }
}