using Vozila.DAL.Entities;
using Vozila.Models;
using Vozila.Models.Common;
using AutoMapper;

namespace Vozila.Repository.Mapper
{
    public class Mappings : Profile
    {
        protected override void Configure()
        {
            CreateMap<VehicleModel, VehicleModelPoco>().ReverseMap();
            CreateMap<VehicleModel, IVehicleModel>().ReverseMap();
            CreateMap<IVehicleModel, VehicleModelPoco>().ReverseMap();

            CreateMap<VehicleMake, VehicleMakePoco>().ReverseMap();
            CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
            CreateMap<IVehicleMake, VehicleMakePoco>().ReverseMap();
        }
    }
}