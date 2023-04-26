using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoRespuesta
{
    public int Idrespuesta { get; set; }

    public int PreguntaId { get; set; }

    public string Texto { get; set; }

    public double? Puntuacion { get; set; }

    public virtual ICollection<IsoEncuestasDetalle> IsoEncuestasDetalles { get; set; } = new List<IsoEncuestasDetalle>();

    public virtual IsoPregunta Pregunta { get; set; }
}
