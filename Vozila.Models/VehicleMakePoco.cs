using System;
using Vozila.Models.Common;

namespace Vozila.Models
{
    public class VehicleMakePoco : IVehicleMake //POCO koristim jer je to C# objekt, neće nasljediti ništa od EF-a
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Abrv { get; set; }

    }
}