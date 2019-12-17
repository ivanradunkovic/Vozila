using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Vozila.Models
{
    /// <summary>
    /// Vehicle model class.
    /// </summary>
    public class VehicleModelPoco : IVehicleModel //POCO koristim jer je to C# objekt, neće nasljediti ništa od EF-a
    {
  
        public Guid Id { get; set; }

        public Guid VehicleMakeId { get; set; }

        //[Required(ErrorMessage = "Enter name of the vehicle")]
        public string Name { get; set; }

        public string Abrv { get; set; }


        /// <summary>
        /// Gets or sets maker of the vehicle.
        /// </summary>
        public virtual IVehicleMake VehicleMake { get; set; }

    }
}
