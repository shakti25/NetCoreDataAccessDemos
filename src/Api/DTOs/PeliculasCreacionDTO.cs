﻿namespace RToora.DemoWebApi.API.DTOs;

public class PeliculasCreacionDTO
{
    public string Titulo { get; set; } = null!;
    public bool EnCines { get; set; }
    public DateTime FechaEstreno { get; set; }
    public List<int> Generos { get; set; } = new List<int>();
    public List<PeliculaActorCreacionDTO> PeliculasActores { get; set; } = new List<PeliculaActorCreacionDTO>();
}
