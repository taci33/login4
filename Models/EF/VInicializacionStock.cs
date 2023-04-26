using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VInicializacionStock
{
    public int IdproductoTipo { get; set; }

    public string Nombre { get; set; }

    public int Idfamilia { get; set; }

    public string Familia { get; set; }

    public int Idproducto { get; set; }

    public string NombreSpa { get; set; }

    public decimal StockInicial { get; set; }

    public decimal StockActual { get; set; }

    public decimal PrecioCompra { get; set; }
}
