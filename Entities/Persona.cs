using System;
using System.Collections.Generic;

namespace Entities;

public partial class Persona
{
    public int IdPersona { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public DateTime? FechaNac { get; set; }

    public int? Legajo { get; set; }

    public string? TipoPersona { get; set; }

    public int? IdPlan { get; set; }

    public virtual ICollection<AlumnosInscripcione> AlumnosInscripciones { get; set; } = new List<AlumnosInscripcione>();

    public virtual ICollection<DocentesCurso> DocentesCursos { get; set; } = new List<DocentesCurso>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
