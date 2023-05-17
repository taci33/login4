using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestionTiposLinea
{
    public int DocumentoGestionId { get; set; }

    public int TipoLineaId { get; set; }

    public int FormularioId { get; set; }

    public virtual DocumentosGestion DocumentoGestion { get; set; }

    public virtual Formulario Formulario { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }

    public virtual ICollection<ProductosTipo> ProductoTipos { get; set; } = new List<ProductosTipo>();
}
