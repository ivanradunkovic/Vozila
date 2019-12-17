using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Common
{
    public class VehicleFilter : IVehicleFilter
    {
   
        /// <param name="findVehicle">Find vehicle.</param>
        /// <param name="makeId">Make id.</param>
        public VehicleFilter(string findVehicle, Guid? makeId)
        {
            this.FindVehicle = findVehicle;
            this.MakeId = makeId.HasValue ? makeId.Value : Guid.Empty;
        }

        public string FindVehicle { get; set; }

        public Guid? MakeId { get; set; }

    }
}