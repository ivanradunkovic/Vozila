using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using PagedList;
using AutoMapper;
using Vozila.DAL;
using Vozila.Common;
using Vozila.Models;
using Vozila.Models.Common;
using Vozila.Repository.Common;
using Vozila.Repository.Mapping;

namespace Vozila.Repository
{

    public class VehicleRepository : IVehicleRepository
    {
       
        private VehicleContext vehicleContext;

        private IMapper mapper;

        public VehicleRepository()
        {
            vehicleContext = new VehicleContext();
            AutoMapperMaps.ConfigureMapping();
            mapper = AutoMapperMaps.GetMapper();
        }
   
        /// <param name="id">Id.</param>
    
        public async Task<IVehicleModel> GetVehicleAsync(Guid id)
        {
            return mapper.Map<VehicleModelPoco>(await vehicleContext.VehicleModels.FindAsync(id));
        }
     
        /// <param name="paging">Paging.</param>
        /// <param name="filterVehicle">Filter vehicle.</param>
        /// <param name="sorting">Sorting.</param>
        
        public async Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting)
        {
            var listOfVehicles = await vehicleContext.VehicleModels.ToListAsync();

            var filteredListOfVehicles = listOfVehicles
                .Where(item => String.IsNullOrEmpty(filterVehicle.FindVehicle) ? item != null : item.Name.Contains(filterVehicle.FindVehicle))
                .Where(item => filterVehicle.MakeId == Guid.Empty ? item != null : item.VehicleMakeId == filterVehicle.MakeId);

            var sortedList = filteredListOfVehicles.OrderByDescending(a => a.Id);
            var mappedList = mapper.Map<List<VehicleModelPoco>>(sortedList);
            var pagedList = mappedList.ToPagedList(paging.PageNumber, paging.PageSize);
            var pagedListOfVehicles = new StaticPagedList<VehicleModelPoco>(pagedList, pagedList.GetMetaData());

            return pagedListOfVehicles;
        }

        /// <param name="vehicleModel">Vehicle model.</param>

        public Task InsertVehicleAsync(IVehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            vehicleModel.Abrv = vehicleModel.Name.Substring(0, 3);
            vehicleContext.VehicleModels.Add(mapper.Map<DAL.Entities.VehicleModel>(vehicleModel));

            return vehicleContext.SaveChangesAsync();
        }

        /// <param name="vehicleModel">Vehicle model.</param>
 
        public Task UpdateVehicleAsync(IVehicleModel vehicleModel)
        {
            mapper.Map<DAL.Entities.VehicleModel>(vehicleModel);
            return vehicleContext.SaveChangesAsync();
        }
      
        /// <param name="id">Id.</param>      
        
        public Task DeleteVehicleAsync(Guid id)
        {
            var oneVehicle = vehicleContext.VehicleModels.Find(id);
            vehicleContext.VehicleModels.Remove(oneVehicle);

            return vehicleContext.SaveChangesAsync();
        }
    }
}
