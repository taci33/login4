using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PartesFormulario
{
    public int IdparteFormulario { get; set; }

    public string Nombre { get; set; }

    public int FormularioId { get; set; }

    public virtual Formulario Formulario { get; set; }

    public virtual ICollection<ProductosConjunto> ProductosConjuntos { get; set; } = new List<ProductosConjunto>();
}
