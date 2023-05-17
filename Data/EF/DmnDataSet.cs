using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DmnDataSet
{
    public int IddataSet { get; set; }

    public string Caption { get; set; }

    /// <summary>
    /// Código único para identificar el DataSet &gt; Formato: [Cod. Entidad]_00000
    /// </summary>
    public string Codigo { get; set; }

    /// <summary>
    /// 0 = cmdUnknown, 1 = cmdText, 2 = cmdTable, 3 = cmdStoredProc, 4 = cmdFile, 5 = cmdTableDirect
    /// </summary>
    public int CommandType { get; set; }

    public string CommandText { get; set; }

    public int QueryFormId { get; set; }

    public int GridDefinitionId { get; set; }

    public virtual ICollection<DmnDataSetParameter> DmnDataSetParameters { get; set; } = new List<DmnDataSetParameter>();

    public virtual GsGridDefinition GridDefinition { get; set; }

    public virtual DmnQueryForm QueryForm { get; set; }
}
