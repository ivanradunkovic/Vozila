using System;
using Vozila.Models.Common;

namespace Vozila.Models
{
    public class VehicleModelPoco : IVehicleModel //POCO koristim jer je to C# objekt, neće nasljediti ništa od EF-a
    {
  
        public Guid Id { get; set; }

        public Guid VehicleMakeId { get; set; }

        public string Name { get; set; }

        public string Abrv { get; set; }

        public virtual IVehicleMake VehicleMake { get; set; }

    }
}
