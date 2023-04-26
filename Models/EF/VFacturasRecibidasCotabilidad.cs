using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VFacturasRecibidasCotabilidad
{
    public int IdfacturaEntrada { get; set; }

    public DateTime? Falta { get; set; }

    public string NumeroFactura { get; set; }

    public bool Abono { get; set; }

    public string Proveedor { get; set; }

    public string FormaPago { get; set; }

    public decimal Total { get; set; }

    public string Estado { get; set; }

    public int? Numero { get; set; }

    public string ReferenciaPersona { get; set; }
}
