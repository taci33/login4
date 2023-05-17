using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsGridColumn
{
    public int Idcolumn { get; set; }

    public int GridDefinitionId { get; set; }

    public string Caption { get; set; }

    public string DataBindingFieldName { get; set; }

    public int PositionBandIndex { get; set; }

    public int PositionRowIndex { get; set; }

    public int PositionColIndex { get; set; }

    /// <summary>
    /// (0 = taLeft, 1 = taRight, 2 = taCenter)
    /// </summary>
    public int Alignment { get; set; }

    public int Width { get; set; }

    public bool? Visible { get; set; }

    public virtual GsGridDefinition GridDefinition { get; set; }
}
