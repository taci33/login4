using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Tpvdescuento
{
    public int Idtpvdescuento { get; set; }

    public string Nombre { get; set; }

    public decimal Descuento { get; set; }
}
