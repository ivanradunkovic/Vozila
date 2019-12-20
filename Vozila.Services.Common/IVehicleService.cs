using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vozila.Common;
using Vozila.Models;
using Vozila.Models.Common;

namespace Vozila.Services.Common
{

    public interface IVehicleService
    {

        /// <param name="id">Id.</param>
        Task<IVehicleModel> GetVehicleAsync(Guid id);

        /// <param name="paging">Paging.</param>
        /// <param name="filterVehicle">Filter vehicle.</param>
        /// <param name="sorting">Sorting.</param>

        Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting);

        /// <param name="vehicleModel">Vehicle model.</param>

        Task InsertVehicleAsync(VehicleModelPoco vehicleModel);

        /// <param name="vehicleModel">Vehicle model.</param>
        /// 
        Task UpdateBaseAsync(IVehicleModel vehicleModel);

        /// <param name="id">Id.</param>

        Task DeleteVehicleAsync(Guid id);
    }
}