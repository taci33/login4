using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CantidadesPrecargaComisione
{
    public double Cantidad { get; set; }

    public int OperacionId { get; set; }

    public double Comision { get; set; }

    public virtual ComisionesOperacione Operacion { get; set; }
}
