using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MaquinasConsumosSaldo
{
    public DateTime Fecha { get; set; }

    public double NlitrosDeposito { get; set; }

    public double NlitrosTotales { get; set; }
}
