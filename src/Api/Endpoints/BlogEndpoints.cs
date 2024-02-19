using Microsoft.EntityFrameworkCore;
using RToora.DemoWebApi.API.Data;
using RToora.DemoWebApi.API.Data.Entities;

namespace RToora.DemoWebApi.API.Endpoints;

public static class BlogEndpoints
{
    public static void Map(WebApplication app)
    {
        // GET
        app.MapGet("api/blogs", async (SampleDBContext context) =>
        {
            return Results.Ok(await context.Blogs.ToListAsync());
        }).WithTags("Blog");

        // POST
        app.MapPost("api/blogs", async (SampleDBContext context, Blog newBlog) =>
        {
            if (newBlog is null)
                return Results.UnprocessableEntity();

            context.Add(newBlog);
            await context.SaveChangesAsync();

            return Results.Created($"api/blogs/{newBlog.Id}", newBlog);
        }).WithTags("Blog");

        // PUT
        app.MapPut("api/blogs/{id}", async (int id, SampleDBContext context, Blog updatedBlog) =>
        {
            var blog = await context.Blogs.FindAsync(id);

            if (blog is null) return Results.NotFound();

            blog.Url = updatedBlog.Url;

            await context.SaveChangesAsync();

            return Results.NoContent();
        }).WithTags("Blog");

        // DELETE
        app.MapDelete("api/blogs/{id}", async (int id, SampleDBContext context) =>
        {
            if (await context.Blogs.FindAsync(id) is Blog blog)
            {
                context.Blogs.Remove(blog);
                await context.SaveChangesAsync();
                return Results.NoContent() ;
            }

            return Results.NotFound();
        }).WithTags("Blog");
    }
}
