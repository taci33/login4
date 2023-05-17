using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoEncuestasDetalle
{
    public int Idlinea { get; set; }

    public int EncuestaId { get; set; }

    public int PreguntaId { get; set; }

    public int? RespuestaId { get; set; }

    public double? Puntuacion { get; set; }

    public virtual IsoEncuesta Encuesta { get; set; }

    public virtual IsoPregunta Pregunta { get; set; }

    public virtual IsoRespuesta Respuesta { get; set; }
}
