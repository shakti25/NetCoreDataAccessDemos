using AutoMapper;
using RToora.DemoWebApi.API.Data;
using RToora.DemoWebApi.API.Data.Entities;
using RToora.DemoWebApi.API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace RToora.DemoWebApi.API.Endpoints;

public static class PeliculasEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapPost("api/peliculas", async (SampleDBContext context, PeliculasCreacionDTO peliculasCreacionDTO, IMapper mapper) =>
        {
            var pelicula = mapper.Map<Pelicula>(peliculasCreacionDTO);

            if(pelicula.Generos is not null )
            {
                foreach (var genero in pelicula.Generos)
                {
                    context.Entry(genero).State = EntityState.Unchanged;
                }
            }

            if(pelicula.PeliculasActores is not null)
            {
                for (int i = 0; i < pelicula.PeliculasActores.Count; i++)
                {
                    pelicula.PeliculasActores[i].Orden = i + 1;
                }
            }

            context.Add(pelicula);
            await context.SaveChangesAsync();
            return Results.Ok();
        }).WithTags("Peliculas");
    }
}
