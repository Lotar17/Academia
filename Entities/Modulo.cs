using System;
using System.Collections.Generic;

namespace UIDesktop;

public partial class Modulo
{
    public int IdModulo { get; set; }

    public string? DescModulo { get; set; }

    public string? Ejecuta { get; set; }

    public virtual ICollection<ModulosUsuario> ModulosUsuarios { get; set; } = new List<ModulosUsuario>();
}
