using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.Models.Common;

namespace Vozila.Repository.Common
{

    public interface IMakeRepository
    {
      
        /// <param name="id">Id.</param>

        Task<IVehicleMake> GetMakerAsync(Guid id);
 
        Task<IEnumerable<IVehicleMake>> GetMakersAsync();
    }
}