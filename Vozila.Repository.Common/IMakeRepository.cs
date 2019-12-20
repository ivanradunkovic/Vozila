using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vozila.Models.Common;

namespace Vozila.Repository.Common
{

    public interface IMakeRepository
    {

        /// <param name="id">Id.</param>

        Task<IVehicleMake> GetMakeAsync(Guid id);

        Task<IEnumerable<IVehicleMake>> GetMakesAsync();
    }
}