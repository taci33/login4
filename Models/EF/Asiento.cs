using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Asiento
{
    public int Clave { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<AsientosDiario> AsientosDiarios { get; set; } = new List<AsientosDiario>();
}
