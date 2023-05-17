using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DmnDataSetRel
{
    public int IddataSet1 { get; set; }

    public int IddataSet2 { get; set; }

    public virtual DmnDataSet IddataSet1Navigation { get; set; }

    public virtual DmnDataSet IddataSet2Navigation { get; set; }
}
