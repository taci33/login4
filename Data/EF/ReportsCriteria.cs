using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ReportsCriteria
{
    public int IdreportCriteria { get; set; }

    public int ReportLauncherId { get; set; }

    public string CriteriaOwnerFormName { get; set; }

    public string CriteriaComponentName { get; set; }

    public string CriteriaComponentPropertyName { get; set; }

    public string ReportComponentFormName { get; set; }

    public string ReportComponentName { get; set; }

    public string DataPipelineName { get; set; }

    public string FieldName { get; set; }

    public string Operator { get; set; }

    public bool? Mandatory { get; set; }

    public virtual ReportsLauncher ReportLauncher { get; set; }
}
