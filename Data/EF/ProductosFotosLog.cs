using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosFotosLog
{
    public int Idlog { get; set; }

    public string Codigo { get; set; }

    public int Operacion { get; set; }

    public bool Procesado { get; set; }

    public DateTime? Fecha { get; set; }
}
