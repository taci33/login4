using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoIndicadoresDetalle
{
    public int Idlinea { get; set; }

    public int IndicadorId { get; set; }

    public int? Numero { get; set; }

    public DateTime? FechaMedicion { get; set; }

    public double? ValorObjetivo { get; set; }

    public double? ValorObtenido { get; set; }

    public bool ConformeObjetivo { get; set; }

    public string Acciones { get; set; }

    public virtual IsoIndicadore Indicador { get; set; }
}
