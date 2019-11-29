using System.Collections.Generic;
using Vozila.Models;

namespace Vozila.DAL
{
    public class VehicleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
        {
            var makes = new List<Make>
            {
            new Make{Id=1,Name="BMW",Abrv="BMW"},
            new Make{Id=2,Name="Ford",Abrv="Ford"},
            new Make{Id=3,Name="Volkswagen",Abrv="VW"},
            new Make{Id=4,Name="Hyundai",Abrv="Hyundai"},
            new Make{Id=5,Name="General Motors",Abrv="GM"}
            };
            makes.ForEach(s => context.Makes.Add(s));
            context.SaveChanges();

            var models = new List<Model>
            {
            new Model{Id=1,MakeId=1,Name="128",Abrv="BMW"},
            new Model{Id=2,MakeId=1,Name="325",Abrv="BMW"},
            new Model{Id=3,MakeId=1,Name="X5",Abrv="BMW"},
            new Model{Id=4,MakeId=2,Name="Mondeo",Abrv="Ford"},
            new Model{Id=5,MakeId=2,Name="Fiesta",Abrv="Ford"},
            new Model{Id=6,MakeId=2,Name="Escort",Abrv="Ford"},
            new Model{Id=7,MakeId=3,Name="Golf",Abrv="VW"},
            new Model{Id=8,MakeId=3,Name="Passat",Abrv="VW"},
            new Model{Id=9,MakeId=3,Name="Arteon",Abrv="VW"},
            new Model{Id=10,MakeId=4,Name="i30",Abrv="Hyundai"},
            new Model{Id=11,MakeId=4,Name="Tuscon",Abrv="Hyundai"},
            new Model{Id=12,MakeId=4,Name="Kona",Abrv="Hyundai"},
            new Model{Id=13,MakeId=5,Name="Chevroler",Abrv="GM"},
            new Model{Id=14,MakeId=5,Name="Buick",Abrv="GM"},
            new Model{Id=15,MakeId=5,Name="Cadillac",Abrv="GM"}
            };
            models.ForEach(s => context.Models.Add(s));
            context.SaveChanges();
        }
    }
}