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

        var cienciaFiccion = new Genero { Id = 5, Nombre = "Ciencia Ficción" };
        var animacion = new Genero { Id = 6, Nombre = "Animación" };
        builder.HasData(cienciaFiccion, animacion);

        builder.HasIndex(g => g.Nombre).IsUnique();
    }
}
