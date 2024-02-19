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

    public DbSet<Blog> Blogs { get; set; }
}
