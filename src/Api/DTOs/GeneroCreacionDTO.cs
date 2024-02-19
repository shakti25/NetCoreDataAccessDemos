using System.ComponentModel.DataAnnotations;

namespace RToora.DemoWebApi.API.DTOs;

public class GeneroCreacionDTO
{
    [StringLength(maximumLength: 150)]
    public string Nombre { get; set; } = null!;
}
