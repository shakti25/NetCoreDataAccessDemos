using Microsoft.EntityFrameworkCore;
using RToora.DemoWebApi.API.Data.Entities;

namespace RToora.DemoWebApi.API.Data;

public class SampleDBContext : DbContext
{
    public SampleDBContext(DbContextOptions options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Blog>().Property(b => b.Url).IsRequired();
    }

    public DbSet<Blog> Blogs { get; set; }
}
