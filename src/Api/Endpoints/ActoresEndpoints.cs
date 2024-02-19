using AutoMapper;
using RToora.DemoWebApi.API.Data;
using RToora.DemoWebApi.API.Data.Entities;
using RToora.DemoWebApi.API.DTOs;

namespace RToora.DemoWebApi.API.Endpoints;

public static class ActoresEndpoints
{
    public static void Map(WebApplication app)
    {
        // POST
        app.MapPost("api/actores", async (SampleDBContext context, ActorCreacionDTO newActor, IMapper mapper) =>
        {
            var actor = mapper.Map<Actor>(newActor);
            context.Add(actor);
            await context.SaveChangesAsync();

            Results.Ok();
        }).WithTags("Actores");
    }
}
