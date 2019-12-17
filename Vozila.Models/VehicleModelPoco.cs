using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.Models.Common;
using System.ComponentModel.DataAnnotations;

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
