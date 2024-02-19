using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RToora.DemoWebApi.API.Data.Entities;

namespace RToora.DemoWebApi.API.Data.Configurations;

public class PeliculaActorEntityConfiguration : IEntityTypeConfiguration<PeliculaActor>
{
    public void Configure(EntityTypeBuilder<PeliculaActor> builder)
    {
        builder.HasKey(pa => new { pa.ActorId, pa.PeliculaId });
    }
}
