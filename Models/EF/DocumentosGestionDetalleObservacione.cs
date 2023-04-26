using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestionDetalleObservacione
{
    public int DocumentoGestionId { get; set; }

    public int CabeceraId { get; set; }

    public int DetalleId { get; set; }

    public int? FirstDocumentoGestionId { get; set; }

    public int? FirstCabeceraId { get; set; }

    public int? FirstDetalleId { get; set; }

    public string Observacion { get; set; }

    public virtual DocumentosGestion DocumentoGestion { get; set; }
}
