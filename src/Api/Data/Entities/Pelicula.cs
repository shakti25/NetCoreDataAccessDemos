namespace RToora.DemoWebApi.API.Data.Entities;

public class Pelicula
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public bool EnCines { get; set; }
    public DateTime FechaEstreno { get; set; }
}
