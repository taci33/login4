using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GdDocumento
{
    public int Iddocumento { get; set; }

    /// <summary>
    /// Para poder establecer relaciones entre Documentos
    /// </summary>
    public int? DocumentoId { get; set; }

    public int? TipoId { get; set; }

    /// <summary>
    /// Nombre Interno del fichero: 9 digitos +  &apos;.&apos; + 5 de extensión. Se autogenera por trigger
    /// </summary>
    public string Fichero { get; set; }

    public int FormatoId { get; set; }

    public string Descripcion { get; set; }

    public string OriginalFileName { get; set; }

    public virtual GdDocumento Documento { get; set; }

    public virtual GdFormatosArchivo Formato { get; set; }

    public virtual ICollection<GdDocumentosEntidade> GdDocumentosEntidades { get; set; } = new List<GdDocumentosEntidade>();

    public virtual ICollection<GdDocumento> InverseDocumento { get; set; } = new List<GdDocumento>();

    public virtual GdTipo Tipo { get; set; }
}
