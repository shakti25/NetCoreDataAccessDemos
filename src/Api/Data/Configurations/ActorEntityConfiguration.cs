using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RToora.DemoWebApi.API.Data.Entities;

namespace RToora.DemoWebApi.API.Data.Configurations;

public class ActorEntityConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.Property(a => a.Nombre).IsRequired();
        builder.Property(a => a.Nombre).HasMaxLength(150);
        builder.Property(a => a.FechaNacimiento).HasColumnType("date");
        builder.Property(a => a.Fortuna).HasPrecision(18, 2);
    }
}
