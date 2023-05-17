using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoTiposNorma
{
    public int IdtipoNorma { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoRequisito> IsoRequisitos { get; set; } = new List<IsoRequisito>();
}
