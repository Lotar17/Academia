using System;
using System.Collections.Generic;

namespace UIDesktop;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public bool Habilitado { get; set; }

    public bool? CambiaClave { get; set; }

    public int? IdPersona { get; set; }

    public virtual Persona? IdPersonaNavigation { get; set; }

    public virtual ICollection<ModulosUsuario> ModulosUsuarios { get; set; } = new List<ModulosUsuario>();
}
