using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace forometodocrud.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    [Column("fecha_nacimiento")]
    public DateTime FechaNacimiento { get; set; }
    public string? Estado { get; set; }
}
