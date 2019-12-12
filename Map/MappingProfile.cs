using ASPNETCORE_AUTOMAPPER.Models;
using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Make, MakeModel>().ForMember(dest => dest.Name, opts => opts.MapFrom(src => new Name
        {
            Id = src.Id,
            Name = src.Name,
            Abrv = src.Abrv
        }));
    }
}