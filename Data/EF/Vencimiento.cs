using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Vencimiento
{
    public int Idvencimiento { get; set; }

    public int FormaPagoId { get; set; }

    public string Nombre { get; set; }

    public int Dias { get; set; }

    public decimal Porcentaje { get; set; }

    public virtual FormasPago FormaPago { get; set; }
}
