﻿using System;
using System.Collections.Generic;

namespace Entities;

public partial class DocentesCurso
{
    public int IdDictado { get; set; }

    public int? IdCurso { get; set; }

    public int? IdDocente { get; set; }

    public int? Cargo { get; set; }

    public virtual Curso? IdCursoNavigation { get; set; }

    public virtual Persona? IdDocenteNavigation { get; set; }
}
