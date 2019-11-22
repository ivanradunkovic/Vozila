﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
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
            new Model{Id=1,MakeId=2,Name="Mondeo",Abrv="Ford"},
            new Model{Id=2,MakeId=2,Name="Fiesta",Abrv="Ford"},
            new Model{Id=3,MakeId=2,Name="Escort",Abrv="Ford"},
            new Model{Id=1,MakeId=3,Name="Gold",Abrv="VW"},
            new Model{Id=2,MakeId=3,Name="Passat",Abrv="VW"},
            new Model{Id=3,MakeId=3,Name="Arteon",Abrv="VW"},
            new Model{Id=1,MakeId=4,Name="i30",Abrv="Hyundai"},
            new Model{Id=2,MakeId=4,Name="Tuscon",Abrv="Hyundai"},
            new Model{Id=3,MakeId=4,Name="Kona",Abrv="Hyundai"},
            new Model{Id=1,MakeId=5,Name="Chevroler",Abrv="GM"},
            new Model{Id=2,MakeId=5,Name="Buick",Abrv="GM"},
            new Model{Id=3,MakeId=5,Name="Cadillac",Abrv="GM"}
            };
            models.ForEach(s => context.Models.Add(s));
            context.SaveChanges();
            var makemodels = new List<MakeModel>
            {
            new MakeModel{MakeId=1,ModelId=1},
            };
            makemodels.ForEach(s => context.MakeModels.Add(s));
            context.SaveChanges();
        }
    }
}