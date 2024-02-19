using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RToora.DemoWebApi.API.Data.Entities;

namespace RToora.DemoWebApi.API.Data.Configurations;

public class PeliculaEntityConfiguration : IEntityTypeConfiguration<Pelicula>
{
    public void Configure(EntityTypeBuilder<Pelicula> builder)
    {
        builder.Property(p => p.Titulo).IsRequired();
        builder.Property(p => p.Titulo).HasMaxLength(150);
        builder.Property(p => p.FechaEstreno).HasColumnType("date");
    }
}
