using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class NicPgcCuentasListado
{
    public string Cuenta { get; set; }

    public string Descripcion { get; set; }

    public byte Nivel { get; set; }
}
