using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ReportsFamilia
{
    public int IdreportFamilia { get; set; }

    public int? ReportFamiliaId { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
