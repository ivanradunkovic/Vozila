using System.Data.Entity;
using Vozila.DAL.Entities;
using Vozila.DAL.Mapping;

namespace Vozila.DAL
{
    public class VehicleContext : DbContext
    {
        public VehicleContext()
            : base("VozilaDb")
        {
            Database.SetInitializer<VehicleContext>(new VehicleDbInitializer());
        }

        public virtual DbSet<VehicleMake> VehicleModels { get; set; }

        public virtual DbSet<VehicleModel> VehicleMakes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  
            modelBuilder.Configurations.Add(new VehicleMakeMap());
            modelBuilder.Configurations.Add(new VehicleModelMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
