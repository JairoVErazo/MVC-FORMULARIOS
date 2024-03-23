using System;
using System.Collections.Generic;

namespace MVC_FORMULARIOS.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string NombreUusario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Pasatiempo { get; set; } = null!;

    public string Curso { get; set; } = null!;

    public string Conocimiento { get; set; } = null!;
}
