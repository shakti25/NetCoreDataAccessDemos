using AutoMapper;
using RToora.DemoWebApi.API.Data;
using RToora.DemoWebApi.API.Data.Entities;
using RToora.DemoWebApi.API.DTOs;

namespace RToora.DemoWebApi.API.Endpoints;

public static class ComentariosEndpoints
{
    public static void Map(WebApplication app)
    {
        // POST
        app.MapPost("api/peliculas/{peliculaId:int}/comentarios", async (int peliculaId, SampleDBContext context, IMapper mapper, ComentarioCreacionDTO comentarioCreacionDTO) =>
        {
            var comentario = mapper.Map<Comentario>(comentarioCreacionDTO);
            comentario.PeliculaId = peliculaId;
            context.Add(comentario);
            await context.SaveChangesAsync();
            return Results.Ok();
        }).WithTags("Comentarios");
    }
}
