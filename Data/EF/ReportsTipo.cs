using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ReportsTipo
{
    public int IdreportTipo { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
