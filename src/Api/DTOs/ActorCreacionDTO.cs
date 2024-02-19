using System.ComponentModel.DataAnnotations;

namespace RToora.DemoWebApi.API.DTOs;

public class ActorCreacionDTO
{
    [StringLength(150)]
    public string Nombre { get; set; } = null!;
    public decimal Fortuna { get; set; }
    public DateTime FechaNacimiento { get; set; }
}
