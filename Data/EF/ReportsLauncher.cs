using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ReportsLauncher
{
    public int IdreportLauncher { get; set; }

    public int? ReportLauncherId { get; set; }

    public int? ReportId { get; set; }

    public string OwnerFormName { get; set; }

    public string ComponentName { get; set; }

    public string ReportComponentName { get; set; }

    public virtual Report Report { get; set; }

    public virtual ICollection<ReportsCriteria> ReportsCriteria { get; set; } = new List<ReportsCriteria>();
}
