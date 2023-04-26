using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FichajesSteep
{
    public int Idsteep { get; set; }

    public int? PrevSteepId { get; set; }

    public int? NextSteepId { get; set; }

    public int TabIndex { get; set; }

    public int SteepNumber { get; set; }

    public int ImageIndexIdle { get; set; }

    public int ImageIndexOk { get; set; }

    public int ImageIndexOnError { get; set; }

    public string HelpTextIdle { get; set; }

    public string HelpTextOnError { get; set; }

    public virtual FichajesSteep InverseNextSteep { get; set; }

    public virtual FichajesSteep NextSteep { get; set; }
}
