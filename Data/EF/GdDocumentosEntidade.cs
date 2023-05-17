using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GdDocumentosEntidade
{
    public int EntidadId { get; set; }

    public int DocumentoId { get; set; }

    /// <summary>
    /// El valor del ID de la Identidad en su tabla correspondiente (x. ej. IDProducto de la tabla Productos)
    /// </summary>
    public int IdentificadorEntidadId { get; set; }

    public virtual GdDocumento Documento { get; set; }

    public virtual GdEntidade Entidad { get; set; }
}
