using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoTiposAccione
{
    public int IdtipoAccion { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoIncidenciasDetalle> IsoIncidenciasDetalles { get; set; } = new List<IsoIncidenciasDetalle>();
}
