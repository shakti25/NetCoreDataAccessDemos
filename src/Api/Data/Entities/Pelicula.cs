using System.Collections.ObjectModel;

namespace RToora.DemoWebApi.API.Data.Entities;

public class Pelicula
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public bool EnCines { get; set; }
    public DateTime FechaEstreno { get; set; }

    public Collection<Comentario> Comentarios { get; set; } = [];
    public Collection<Genero> Generos { get; set; } = new Collection<Genero>();
    public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();
}
