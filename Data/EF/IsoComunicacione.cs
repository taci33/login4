using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoComunicacione
{
    public int Idcomunicacion { get; set; }

    public string Descripcion { get; set; }

    public string DocumentoDemanda { get; set; }

    public int? TipoDestDemandaId { get; set; }

    public int? RespDemandaId { get; set; }

    public string Contenido { get; set; }

    public string DocumentoRespuesta { get; set; }

    public int? TipoDestRespuestaId { get; set; }

    public int? RespRespuestaId { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaRespuesta { get; set; }

    public string ContenidoRespuesta { get; set; }

    public virtual DocumentosGestionDestinatario TipoDestDemanda { get; set; }

    public virtual DocumentosGestionDestinatario TipoDestRespuesta { get; set; }
}
