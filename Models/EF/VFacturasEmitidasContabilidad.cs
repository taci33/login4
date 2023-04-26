using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VFacturasEmitidasContabilidad
{
    public int IdfacturaSalida { get; set; }

    public DateTime? Falta { get; set; }

    public string NumeroFactura { get; set; }

    public bool Abono { get; set; }

    public string Cliente { get; set; }

    public string FormaPago { get; set; }

    public decimal TotalFactura { get; set; }

    public string Estado { get; set; }

    public int? Numero { get; set; }
}
