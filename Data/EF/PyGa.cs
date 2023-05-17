using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PyGa
{
    public int Clave { get; set; }

    public string Codigo { get; set; }

    public string Formato { get; set; }

    public string Nombre { get; set; }

    public double? Total { get; set; }

    public double? TotalA { get; set; }

    public int? Orden { get; set; }

    public int? Equivale { get; set; }
}
