using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PartesTipo
{
    public int IdparteTipo { get; set; }

    public string Nombre { get; set; }

    public int TipoEdicionParte { get; set; }

    public int FormularioId { get; set; }

    public int TipoLineaId { get; set; }

    public virtual Formulario Formulario { get; set; }

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual TiposLinea TipoLinea { get; set; }

    public virtual ICollection<OrdenesFabricacionTipo> Oftipos { get; set; } = new List<OrdenesFabricacionTipo>();
}
