using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsUsrOperator
{
    public int Idoperator { get; set; }

    public string Operator { get; set; }

    public virtual ICollection<DmnDataSetParameter> DmnDataSetParameters { get; set; } = new List<DmnDataSetParameter>();
}
