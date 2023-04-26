using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesSeriadasEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool PartesAllowModify { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalles { get; set; } = new List<OrdenesSeriadasDetalle>();
}
