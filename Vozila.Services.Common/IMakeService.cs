using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vozila.Models.Common;

namespace Vozila.Services.Common
{
    public interface IMakeService
    {
     
        Task<IEnumerable<IVehicleMake>> GetMakesAsync();

        /// <param name="id">Id.</param>
        Task<IVehicleMake> GetMakeAsync(Guid id);

    }
}