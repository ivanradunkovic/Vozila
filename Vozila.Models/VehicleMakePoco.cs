using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.Models.Common;

namespace Vozila.Models
{
    public class VehicleMakerPoco : IVehicleMake //POCO koristim jer je to C# objekt, neće nasljediti ništa od EF-a
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Abrv { get; set; }

    }
}