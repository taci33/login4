using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsInternalType
{
    public int IdinternalType { get; set; }

    public string Name { get; set; }

    public string SqlName { get; set; }

    public string DelphiFieldClassName { get; set; }

    public int Length { get; set; }

    public bool VariableLength { get; set; }

    public bool AllowNulls { get; set; }

    public virtual ICollection<GsUsrType> GsUsrTypes { get; set; } = new List<GsUsrType>();
}
