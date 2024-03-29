﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;
using Vozila.DAL;
using Vozila.Models;
using Vozila.Models.Common;
using Vozila.Repository.Common;
using Vozila.Repository.Mapping;

namespace Vozila.Repository
{
    public class MakeRepository : IMakeRepository
    {
       
        private VehicleContext vehicleContext;

        private IMapper mapper;

        public MakeRepository()
        {
            vehicleContext = new VehicleContext();
            AutoMapperMaps.ConfigureMapping();
            mapper = AutoMapperMaps.GetMapper();
        }

        public async Task<IEnumerable<IVehicleMake>> GetMakesAsync()
        {
            return mapper.Map<IEnumerable<VehicleMakePoco>>(await vehicleContext.VehicleMakes.ToListAsync());
        }
 
        /// <param name="id">Id.</param>
       
        public async Task<IVehicleMake> GetMakeAsync(Guid id)
        {
            return mapper.Map<VehicleMakePoco>(await vehicleContext.VehicleMakes.FindAsync(id));
        }
    }
}
