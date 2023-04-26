using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FichajesTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<FichajesDetalle> FichajesDetalles { get; set; } = new List<FichajesDetalle>();
}
