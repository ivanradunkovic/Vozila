using Vozila.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Vozila.DAL
{
    public class VehicleContext : DbContext
    {
        public VehicleContext() : base("VehicleContext")
        {

        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }
}