using System;
using System.Collections.Generic;

namespace UIDesktop;

public partial class Especialidade
{
    public int IdEspecialidad { get; set; }

    public string DescEspecialidad { get; set; } = null!;

    public virtual ICollection<Plane> Planes { get; set; } = new List<Plane>();
}
