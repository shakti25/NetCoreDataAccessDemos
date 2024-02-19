using Microsoft.EntityFrameworkCore;
using RToora.DemoWebApi.API.Data.Entities;
using System.Reflection;

namespace RToora.DemoWebApi.API.Data;

public class SampleDBContext : DbContext
{
    public SampleDBContext(DbContextOptions options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(500);
    }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Actor> Actores { get; set; }
    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<Comentario> Comentarios { get; set; }
}
