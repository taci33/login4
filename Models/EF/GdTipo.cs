using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GdTipo
{
    public int Idtipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<GdDocumento> GdDocumentos { get; set; } = new List<GdDocumento>();
}
