using Microsoft.EntityFrameworkCore;
using RToora.DemoWebApi.API.Data;
using RToora.DemoWebApi.API.Data.Entities;
using RToora.DemoWebApi.API.DTOs;

namespace RToora.DemoWebApi.API.Endpoints;

public class GenerosEndpoints
{
    public static void Map(WebApplication app)
    {
        // GET
        app.MapGet("api/generos", async (SampleDBContext context) =>
        {
            return Results.Ok(await context.Generos.ToListAsync());
        }).WithTags("Generos");

        // GET /id
        app.MapGet("api/generos/{id:int}", async (int id, SampleDBContext context) =>
        {
            var genero = await context.Generos.FindAsync(id);

            if (genero is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(genero);

        }).WithTags("Generos");

        // POST
        app.MapPost("api/generos", async (SampleDBContext context, GeneroCreacionDTO newGenero) =>
        {
            var genero = new Genero { Nombre = newGenero.Nombre };
            context.Add(genero);
            await context.SaveChangesAsync();
            return Results.Created($"api/generos/{genero.Id}", genero);
        }).WithTags("Generos");
    }
}
