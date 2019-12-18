﻿using AutoMapper;

namespace Vozila.Repository.Mapper
{
    public static class AutoMapperMaps
    {
        private static IMapper mapper = null;

        public static IMapper GetMapper()
        {
            return mapper;
        }

        public static void ConfigureMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Mappings>(); 
            });

            mapper = config.CreateMapper();
        }

    }
}