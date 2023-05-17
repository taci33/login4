using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VRemesasVenta
{
    public int Idremesa { get; set; }

    public string NumeroFactura { get; set; }

    public string NumeroRemesa { get; set; }

    public string PersonaNombre { get; set; }

    public DateTime FechaCargo { get; set; }

    public string Cccadeudo { get; set; }

    public decimal Importe { get; set; }

    public bool Pagado { get; set; }

    public bool Devuelto { get; set; }

    public string Nombre { get; set; }

    public string NumeroVencimiento { get; set; }
}
