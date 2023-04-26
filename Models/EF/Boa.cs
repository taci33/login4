using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Boa
{
    public int Clave { get; set; }

    public string Ap { get; set; }

    public string Nivel1 { get; set; }

    public string Nivel2 { get; set; }

    public string Nivel3 { get; set; }

    public string Formato { get; set; }

    public string Codigo { get; set; }

    public string Nombre { get; set; }

    public double? Total { get; set; }
}
