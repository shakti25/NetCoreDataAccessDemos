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

        CreateMap<PeliculasCreacionDTO, Pelicula>().ForMember(ent => ent.Generos, dto => dto.MapFrom(campo => campo.Generos.Select(id => new Genero { Id = id })));
        CreateMap<PeliculaActorCreacionDTO, PeliculaActor>();

        CreateMap<ComentarioCreacionDTO, Comentario>();
    }
}
