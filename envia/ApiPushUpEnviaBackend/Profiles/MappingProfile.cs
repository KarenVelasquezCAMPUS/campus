using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace ApiPushUpEnviaBackend.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {

        CreateMap<User,UserDto>().ReverseMap();
        CreateMap<User, RegisterDto>().ReverseMap();
        CreateMap<Rol,RolDto>().ReverseMap();
        

    }
}