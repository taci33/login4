using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RpReportsCliente
{
    public int IdreportPersona { get; set; }

    public int PersonaId { get; set; }

    public int ReportId { get; set; }

    public int Ncopias { get; set; }
}
