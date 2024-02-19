using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RToora.DemoWebApi.API.Data.Entities;

namespace RToora.DemoWebApi.API.Data.Configurations;

public class GeneroEntityConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.Property(g => g.Nombre).IsRequired();
        builder.Property(g => g.Nombre).HasMaxLength(150);
    }
}
