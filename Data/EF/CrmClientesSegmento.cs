using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmClientesSegmento
{
    public int IdclienteSegmento { get; set; }

    public int PersonaId { get; set; }

    public int? ContactoId { get; set; }

    public int SegmentoId { get; set; }

    public string Valor { get; set; }

    public virtual ClientesContacto Contacto { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual CrmSegmento Segmento { get; set; }
}
