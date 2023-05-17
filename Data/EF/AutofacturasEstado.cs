using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AutofacturasEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool AllowModify { get; set; }

    public virtual ICollection<Autofactura> Autofacturas { get; set; } = new List<Autofactura>();
}
