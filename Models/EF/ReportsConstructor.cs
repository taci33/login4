using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ReportsConstructor
{
    public int IdreportConstructor { get; set; }

    public string Constructor { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
