﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Models.Common
{
    public interface IVehicleMake
    {
   
        Guid Id { get; set; }

        string Name { get; set; }

        string Abrv { get; set; }

    }
}
