using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GdEntidade
{
    public int Identidad { get; set; }

    public string Nombre { get; set; }

    public int FormularioId { get; set; }

    public virtual Formulario Formulario { get; set; }

    public virtual ICollection<GdDocumentosEntidade> GdDocumentosEntidades { get; set; } = new List<GdDocumentosEntidade>();

    public virtual GsEntidade IdentidadNavigation { get; set; }
}
