using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ExpPaquetesFormato
{
    public int Idformato { get; set; }

    public string Nombre { get; set; }

    public double L { get; set; }

    public double H { get; set; }

    public double A { get; set; }

    public virtual ICollection<ExpedicionesDetalle> ExpedicionesDetalles { get; set; } = new List<ExpedicionesDetalle>();
}
