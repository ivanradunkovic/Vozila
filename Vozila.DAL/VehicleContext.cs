using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Vozila.DAL.Models;
using Vozila.DAL.Entities;
using Vozila.DAL.Mapping;

namespace Vozila.DAL
{
    public class VehicleContext : DbContext
    {
        public VehicleContext()
            : base("VehicleDb")
        {
            Database.SetInitializer<VehicleContext>(new VehicleDbInitializer());
        }

        public virtual DbSet<VehicleMake> VehicleModels { get; set; }

        public virtual DbSet<VehicleModel> VehicleMakers { get; set; }

        public virtual DbSet<VehicleList> VehicleCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  
            modelBuilder.Configurations.Add(new VehicleMakeMap());
            modelBuilder.Configurations.Add(new VehicleModelMap());
            modelBuilder.Configurations.Add(new VehicleListMap());

            base.OnModelCreating(modelBuilder);
        }


    }
}
