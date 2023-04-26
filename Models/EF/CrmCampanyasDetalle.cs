using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanyasDetalle
{
    public int Idlinea { get; set; }

    public long? Idcdbo { get; set; }

    public int CabeceraId { get; set; }

    public DateTime Femision { get; set; }

    public int? DocumentoId { get; set; }

    public virtual CrmCampanya Cabecera { get; set; }

    public virtual CrmCampanyasDocumento Documento { get; set; }

    public virtual CrmCampanyasDetalleCdbo IdcdboNavigation { get; set; }
}
