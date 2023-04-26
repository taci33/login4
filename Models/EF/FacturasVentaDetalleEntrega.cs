using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FacturasVentaDetalleEntrega
{
    public int Identrega { get; set; }

    public int CabeceraId { get; set; }

    public int LineaId { get; set; }

    public double Cantidad { get; set; }

    public DateTime FechaEntrega { get; set; }

    public DateTime FechaAlta { get; set; }
}
