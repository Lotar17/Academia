using System;
using System.Collections.Generic;

namespace Entities;

public partial class Plane
{
    public int IdPlan { get; set; }

    public string? DescPlan { get; set; }

    public int? IdEspecialidad { get; set; }

    public virtual ICollection<Comisione> Comisiones { get; set; } = new List<Comisione>();

    public virtual Especialidade? IdEspecialidadNavigation { get; set; }

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();
}
