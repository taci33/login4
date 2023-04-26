using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Tpvpromocione
{
    public int Idtpvpromocion { get; set; }

    public string Puntos { get; set; }

    public decimal Dinero { get; set; }

    public string Promocion { get; set; }
}
