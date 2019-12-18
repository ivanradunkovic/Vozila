using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vozila.Models.Common;
using Vozila.Common;

namespace Vozila.Repository.Common
{

    public interface IVehicleRepository
    {
        
        /// <param name="id">Id.</param>
        Task<IVehicleModel> GetVehicleAsync(Guid id);
       
        /// <param name="paging">Paging.</param>
        /// <param name="filterVehicle">Filter vehicle.</param>
        /// <param name="sorting">Sorting.</param>      
        Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting);
  
        /// <param name="vehicleModel">Vehicle model.</param>
        Task InsertVehicleAsync(IVehicleModel vehicleModel);
   
        /// <param name="vehicleModel">Vehicle model.</param> 
        Task UpdateVehicleAsync(IVehicleModel vehicleModel);
      
        /// <param name="id">Id.</param>
        Task DeleteVehicleAsync(Guid id);
    }
}