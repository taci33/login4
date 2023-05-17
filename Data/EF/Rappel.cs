using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Rappel
{
    public int Idrappel { get; set; }

    public string Nombre { get; set; }

    public decimal? Facturacion { get; set; }

    public decimal? Descuento { get; set; }

    public int? MesesDto { get; set; }
}
