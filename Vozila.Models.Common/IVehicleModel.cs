﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Models.Common
{
    public interface IVehicleModel
    {
     
        Guid Id { get; set; }

        Guid VehicleMakeId { get; set; }

        string Name { get; set; }

        string Abrv { get; set; }

        IVehicleMake VehicleMake { get; set; }

    }
}
