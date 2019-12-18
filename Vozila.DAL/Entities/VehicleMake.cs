using System;
using System.Collections.Generic;

namespace Vozila.DAL.Entities
{
    public class VehicleMake
    {
        
        public Guid Id { get; set; } //Guid je 128-bitni int (16 baytova). Koristi se kad je god potreban unique identifikator. Mala je mogućnost da bude dupliciran

        public string Name { get; set; }

        public string Abrv { get; set; }

        public ICollection<VehicleModel> VehicleModels { get; set; }
    }
}