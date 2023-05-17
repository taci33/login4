using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DatosTicket
{
    public int Idcabecera { get; set; }

    public int? Numero { get; set; }

    public DateTime? Fecha { get; set; }

    public string Cliente { get; set; }

    public string Empleado { get; set; }

    public string CodProd { get; set; }

    public string Producto { get; set; }

    public double? Cantidad { get; set; }

    public double Precio { get; set; }

    public decimal? PrecioVentaRebajado { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? TotalNeto { get; set; }

    public decimal? Total { get; set; }

    public decimal? Pvp { get; set; }

    public int? Caja { get; set; }
}
