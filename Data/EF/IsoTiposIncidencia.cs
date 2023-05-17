using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoTiposIncidencia
{
    public int IdtipoIncidencia { get; set; }

    public int? TipoDestinatarioId { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<IsoIncidencia> IsoIncidencia { get; set; } = new List<IsoIncidencia>();

    public virtual DocumentosGestionDestinatario TipoDestinatario { get; set; }
}
