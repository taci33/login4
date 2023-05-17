using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RpReportsDg
{
    public int IdreportDg { get; set; }

    public int DocumentoGestionId { get; set; }

    public int CabeceraId { get; set; }

    public int ReportId { get; set; }

    public int Ncopias { get; set; }
}
