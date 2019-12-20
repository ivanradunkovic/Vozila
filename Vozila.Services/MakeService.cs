﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vozila.Repository;
using Vozila.Models.Common;
using Vozila.Services.Common;
using Vozila.Repository.Common;

namespace Vozila.Services
{
    public class MakeService : IMakeService
    {
        private IMakeRepository makeRepository;

        public MakeService()
        {
            makeRepository = new MakeRepository();
        }

        public async Task<IEnumerable<IVehicleMake>> GetMakesAsync()
        {
            return await makeRepository.GetMakesAsync();
        }

        /// <param name="id">Id.</param>
        public async Task<IVehicleMake> GetMakeAsync(Guid id)
        {
            return await makeRepository.GetMakeAsync(id);
        }
    }
}