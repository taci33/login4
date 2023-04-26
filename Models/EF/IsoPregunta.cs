using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoPregunta
{
    public int Idpregunta { get; set; }

    public string Texto { get; set; }

    public double? Ponderacion { get; set; }

    public virtual ICollection<IsoEncuestasDetalle> IsoEncuestasDetalles { get; set; } = new List<IsoEncuestasDetalle>();

    public virtual ICollection<IsoRespuesta> IsoRespuesta { get; set; } = new List<IsoRespuesta>();
}
