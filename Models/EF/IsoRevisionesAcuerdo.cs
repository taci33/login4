using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoRevisionesAcuerdo
{
    public int IdrevisionAcuerdo { get; set; }

    public int RevisionId { get; set; }

    public int? Numero { get; set; }

    public string Aspecto { get; set; }

    public string Mejora { get; set; }

    public string IndPropio { get; set; }

    public string IndSector { get; set; }

    public string IndCompetencia { get; set; }

    public DateTime? FechaPrevista { get; set; }

    public DateTime? FechaCumplimiento { get; set; }

    public bool Eficaz { get; set; }

    public virtual IsoRevisione Revision { get; set; }
}
