using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Wizard
{
    public int Idwizard { get; set; }

    public int Step { get; set; }

    public string Text { get; set; }
}
