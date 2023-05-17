using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoTiposVencimiento
{
    public int IdtipoVencimiento { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoVencimiento> IsoVencimientos { get; set; } = new List<IsoVencimiento>();
}
