using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GdAplicacione
{
    public int Idaplicacion { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<GdFormatosArchivo> GdFormatosArchivos { get; set; } = new List<GdFormatosArchivo>();
}
