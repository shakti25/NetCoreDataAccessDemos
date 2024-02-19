using AutoMapper;
using RToora.DemoWebApi.API.Data.Entities;
using RToora.DemoWebApi.API.DTOs;

namespace RToora.DemoWebApi.API.Utilities;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<GeneroCreacionDTO, Genero>();
        CreateMap<ActorCreacionDTO, Actor>();
    }
}
