using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AsientosDiario
{
    public int Clave { get; set; }

    public int Apunte { get; set; }

    public string Cuenta { get; set; }

    public string Concepto { get; set; }

    public string Dh { get; set; }

    public double Importe { get; set; }

    public double? TipoIva { get; set; }

    public int? IvagrupoId { get; set; }

    public int? CentroCosteId { get; set; }

    public int NumeroApunte { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual Asiento ClaveNavigation { get; set; }
}
