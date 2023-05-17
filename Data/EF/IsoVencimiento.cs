using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoVencimiento
{
    public int Idvencimiento { get; set; }

    public string Nombre { get; set; }

    public int? TipoVencimientoId { get; set; }

    public string Descripcion { get; set; }

    public int? TipoDestinatarioId { get; set; }

    public int? DestinatarioId { get; set; }

    public DateTime? FechaUltimaRevision { get; set; }

    public DateTime? FechaProximaRevision { get; set; }

    public int? FrecuenciaId { get; set; }

    public virtual IsoFrecuencia Frecuencia { get; set; }

    public virtual DocumentosGestionDestinatario TipoDestinatario { get; set; }

    public virtual IsoTiposVencimiento TipoVencimiento { get; set; }
}
