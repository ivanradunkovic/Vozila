using AutoMapper;
using Vozila.Repository.Mapper;

namespace Vozila.Repository.Mapping
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