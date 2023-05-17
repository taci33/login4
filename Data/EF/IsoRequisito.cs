using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoRequisito
{
    public int Idrequisito { get; set; }

    public string Nombre { get; set; }

    public int? DocumentoId { get; set; }

    public int? TipoNormaId { get; set; }

    /// <summary>
    /// En lugar de ModuloCalidadID
    /// </summary>
    public int ModuloGestionId { get; set; }

    public bool EnVigor { get; set; }

    public DateTime? FechaVigor { get; set; }

    public string Resumen { get; set; }

    public string Ambito { get; set; }

    public string Derogada { get; set; }

    public virtual IsoDocumento Documento { get; set; }

    public virtual ModulosGestion ModuloGestion { get; set; }

    public virtual IsoTiposNorma TipoNorma { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Puesto> Puestos { get; set; } = new List<Puesto>();
}
