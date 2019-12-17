﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.DAL.Entities
{
    public class VehicleMake
    {
        
        public Guid Id { get; set; } //Guid je 128-bitni int (16 baytova). Koristi se kad je god potreban unique identifikator. Mala je mogućnost da bude dupliciran

        public string Name { get; set; }

        public string Abrv { get; set; }

        public ICollection<VehicleModel> VeehicleModels { get; set; }
    }
}