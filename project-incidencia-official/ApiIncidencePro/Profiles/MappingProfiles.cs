using ApiIncidencePro.Dtos;
using AutoMapper;
using Domain.Entities;

namespace ApiIncidencePro.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles(){
        CreateMap<Incidence, IncidenceDto>()
        .ReverseMap()
        .ForMember(o => o.IncidenceDetails, d => d.Ignore()); // Previene el null
        CreateMap<IncidenceDetail, IncidenceDetailDto>().ReverseMap();
    }
}