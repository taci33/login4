using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EscalasMedida
{
    public int IdescalaMedida { get; set; }

    public double LookupValue { get; set; }

    public string LookupText { get; set; }
}
