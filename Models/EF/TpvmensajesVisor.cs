using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TpvmensajesVisor
{
    public int Idmensaje { get; set; }

    public int NumLinea { get; set; }

    public string Texto { get; set; }

    public bool? Activo { get; set; }
}
