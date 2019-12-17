using System;

namespace Vozila.Common
{
    public interface IVehicleFilter
    {
        string FindVehicle { get; set; }

        Guid? MakeId { get; set; }

    }
}
