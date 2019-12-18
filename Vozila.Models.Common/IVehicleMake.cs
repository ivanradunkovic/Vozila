using System;

namespace Vozila.Models.Common
{
    public interface IVehicleMake
    {
   
        Guid Id { get; set; }

        string Name { get; set; }

        string Abrv { get; set; }

    }
}
