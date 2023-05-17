using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Report
{
    public int Idreport { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int? ReportFamiliaId { get; set; }

    public int ReportTipoId { get; set; }

    public string FileName { get; set; }

    public int? CriteriaFormId { get; set; }

    public int ReportConstructorId { get; set; }

    /// <summary>
    /// Indica si se tiene que mostrar o no el formulario con el Check Impreso para dar el report por Impreso o no
    /// </summary>
    public bool ShowPrintedCheckForm { get; set; }

    /// <summary>
    /// Indica si el nombre de archivo para exportar se toma del campo Nombre, en caso contrario se toma de la Entidad
    /// </summary>
    public bool ExportNameFromReportName { get; set; }

    public virtual ReportsConstructor ReportConstructor { get; set; }

    public virtual ReportsFamilia ReportFamilia { get; set; }

    public virtual ReportsTipo ReportTipo { get; set; }

    public virtual ICollection<ReportsLauncher> ReportsLaunchers { get; set; } = new List<ReportsLauncher>();

    public virtual ICollection<GsEntidade> Entidads { get; set; } = new List<GsEntidade>();
}
