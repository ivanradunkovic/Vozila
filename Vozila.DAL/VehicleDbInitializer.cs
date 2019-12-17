using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Vozila.Models;
using Vozila.DAL.Entities;

namespace Vozila.DAL
{
    public class VehicleDbInitializer : DropCreateDatabaseIfModelChanges<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
        {
            var BMW = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "BMW",
                Abrv = "BMW",
            };
            context.VehicleMakes.Add(BMW);

            var Ford = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "Ford",
                Abrv = "Ford"
            };
            context.VehicleMakes.Add(Ford);

            var Volkswagen = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "Volkwagen",
                Abrv = "VW"
            };
            context.VehicleMakes.Add(Volkswagen);

            var Hyundai = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "Hyundai",
                Abrv = "Hyundai"
            };
            context.VehicleMakes.Add(Hyundai);

            var GeneralMotors = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "General Motors",
                Abrv = "GM"
            };
            context.VehicleMakes.Add(GeneralMotors);

            for (int i = 0; i < 15; i++)
            {
                var Car1 = new VehicleModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "X5",
                    Abrv = "BMW"
                };

                var Car2 = new VehicleModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Corsa",
                    Abrv = "Ford"
                };

                context.VehicleModels.Add(Car1);
                context.VehicleModels.Add(Car2);
            }


            base.Seed(context);
        }
    }
}
