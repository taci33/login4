using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TpvformasPago
{
    public int IdtpvformaPago { get; set; }

    public string Nombre { get; set; }

    public string CuentaContableTickets { get; set; }
}
