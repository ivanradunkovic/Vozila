using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vozila.Common;
using Vozila.Models;
using Vozila.Models.Common;
using Vozila.Repository;
using Vozila.Repository.Common;
using Vozila.Services.Common;

namespace Vozila.Services
{

    public class VehicleService : IVehicleService
    {

        private IVehicleRepository vehicleRepository;

        public VehicleService()
        {
            vehicleRepository = new VehicleRepository();
        }

        /// <param name="id">Id.</param>
        public async Task<IVehicleModel> GetVehicleAsync(Guid id)
        {
            return await vehicleRepository.GetVehicleAsync(id);
        }

        /// <param name="paging">Paging.</param>
        /// <param name="filterVehicle">Filter vehicle.</param>
        /// <param name="sorting">Sorting.</param>
        public async Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting)
        {
            return await vehicleRepository.GetVehiclesAsync(paging, filterVehicle, sorting);
        }

        /// <param name="vehicleModel">Vehicle model.</param>
        public Task InsertVehicleAsync(VehicleModelPoco vehicleModel)
        {
            return vehicleRepository.InsertVehicleAsync(vehicleModel);
        }

        /// <param name="vehicleModel">Vehicle model.</param>
        public Task UpdateBaseAsync(IVehicleModel vehicleModel)
        {
            return vehicleRepository.UpdateVehicleAsync(vehicleModel);
        }

        /// <param name="id">Id.</param>
        public Task DeleteVehicleAsync(Guid id)
        {
            return vehicleRepository.DeleteVehicleAsync(id);
        }
    }
}