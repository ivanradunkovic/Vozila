using System;

namespace Vozila.DAL.Entities
{
    public class VehicleModel
    {

        public Guid Id { get; set; } //Guid je 128-bitni int (16 baytova). Koristi se kad je god potreban unique identifikator. Mala je mogućnost da bude dupliciran

        public Guid VehicleMakeId { get; set; } //Guid je 128-bitni int (16 baytova). Koristi se kad je god potreban unique identifikator. Mala je mogućnost da bude dupliciran

        public string Name { get; set; }

        public string Abrv { get; set; }

        public virtual VehicleMake VehicleMake { get; set; }

    }
}