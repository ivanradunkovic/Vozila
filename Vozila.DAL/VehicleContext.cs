using System.Data.Entity;
using Vozila.DAL.Entities;
using Vozila.DAL.Mapping;

namespace Vozila.DAL
{
    public class VehicleContext : DbContext
    {
        public VehicleContext()
            : base("VehicleContext")
        {
            Database.SetInitializer<VehicleContext>(new VehicleDbInitializer());
        }

        public virtual DbSet<VehicleMake> Makes { get; set; }

        public virtual DbSet<VehicleModel> Models { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  
            modelBuilder.Configurations.Add(new VehicleMakeMap());
            modelBuilder.Configurations.Add(new VehicleModelMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
