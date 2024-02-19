using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RToora.DemoWebApi.API.Data.Entities;

namespace RToora.DemoWebApi.API.Data.Configurations;

public class ComentarioEntityConfiguration : IEntityTypeConfiguration<Comentario>
{
    public void Configure(EntityTypeBuilder<Comentario> builder)
    {
        builder.Property(c => c.Contenido).HasMaxLength(500);
    }
}
