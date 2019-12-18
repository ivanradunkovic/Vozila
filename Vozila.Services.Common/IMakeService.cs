using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.Models.Common;

namespace Vozila.Services.Common
{
    public interface IMakerService
    {
        Task<IEnumerable<IVehicleMake>> GetMakersAsync();
    
        /// <param name="id">Id.</param>
    
        Task<IVehicleMake> GetMakerAsync(Guid id);

    }
}