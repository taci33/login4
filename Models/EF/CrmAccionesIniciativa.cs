using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmAccionesIniciativa
{
    public int Idiniciativa { get; set; }

    public string Nombre { get; set; }

    public int Orden { get; set; }

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();
}
