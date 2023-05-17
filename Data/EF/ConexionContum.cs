using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ConexionContum
{
    public string LugarConexion { get; set; }

    public string CuentaRecibo { get; set; }

    public string ConceptoRecibo { get; set; }

    public string CuentaFactura1 { get; set; }

    public string CuentaFactura2 { get; set; }

    public string ConceptoFactura { get; set; }
}
