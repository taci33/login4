using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LotesEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Lote> Lotes { get; set; } = new List<Lote>();
}
