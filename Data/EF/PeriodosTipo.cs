using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PeriodosTipo
{
    public int IdperiodoTipo { get; set; }

    public string Tipo { get; set; }

    public int Division { get; set; }

    public virtual ICollection<Periodo> Periodos { get; set; } = new List<Periodo>();
}
