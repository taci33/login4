using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class NicDiccionario
{
    public int IdnicDiccionario { get; set; }

    public string CuentaOrigen { get; set; }

    public string DescOrigen { get; set; }

    public string CuentaDestino { get; set; }

    public string DescDestino { get; set; }
}
