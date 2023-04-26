using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Descuento
{
    public int Iddescuento { get; set; }

    public string Nombre { get; set; }

    public decimal Porcentaje { get; set; }
}
