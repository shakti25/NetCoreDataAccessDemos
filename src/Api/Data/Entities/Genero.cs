using System.Collections.ObjectModel;

namespace RToora.DemoWebApi.API.Data.Entities;

public class Genero
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;

    public Collection<Pelicula> Peliculas { get; set; } = new Collection<Pelicula>();
}
