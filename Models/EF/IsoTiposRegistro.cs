using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoTiposRegistro
{
    public int IdtipoRegistro { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoDocumento> IsoDocumentos { get; set; } = new List<IsoDocumento>();

    public virtual ICollection<IsoRegistro> IsoRegistros { get; set; } = new List<IsoRegistro>();
}
