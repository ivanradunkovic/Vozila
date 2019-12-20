using System;

namespace Vozila.Common
{
    public class VehicleFilter : IVehicleFilter
    {
        private Guid id;

        /// <param name="findVehicle">Find vehicle.</param>
        /// <param name="makeId">Make id.</param>
        public VehicleFilter(string findVehicle, Guid? makeId)
        {
            this.FindVehicle = findVehicle;
            this.MakeId = makeId.HasValue ? makeId.Value : Guid.Empty;
        }

        public VehicleFilter(Guid id, string findVehicle, Guid? makeId)
        {
            this.id = id;
            FindVehicle = findVehicle;
            MakeId = makeId;
        }

        public string FindVehicle { get; set; }

        public Guid? MakeId { get; set; }

    }
}