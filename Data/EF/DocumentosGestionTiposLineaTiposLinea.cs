using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestionTiposLineaTiposLinea
{
    public int DocumentoGestionId { get; set; }

    public int TipoLineaId { get; set; }

    public int ParentTipoLineaId { get; set; }

    public int FormularioId { get; set; }

    public virtual DocumentosGestion DocumentoGestion { get; set; }

    public virtual Formulario Formulario { get; set; }

    public virtual TiposLinea ParentTipoLinea { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }
}
