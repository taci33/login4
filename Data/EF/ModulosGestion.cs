using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ModulosGestion
{
    public int IdmoduloGestion { get; set; }

    public string Nombre { get; set; }

    public bool Activo { get; set; }

    /// <summary>
    /// N║ de decimales empleados en cada m¾dulo
    /// </summary>
    public int? Precision { get; set; }

    public int? ModuloGestionId { get; set; }

    public virtual ICollection<DocumentosGestion> DocumentosGestions { get; set; } = new List<DocumentosGestion>();

    public virtual ICollection<ModulosGestion> InverseModuloGestion { get; set; } = new List<ModulosGestion>();

    public virtual ICollection<IsoRequisito> IsoRequisitos { get; set; } = new List<IsoRequisito>();

    public virtual ModulosGestion ModuloGestion { get; set; }

    public virtual ICollection<PermisosCategoria> PermisosCategoria { get; set; } = new List<PermisosCategoria>();

    public virtual ICollection<ProductosBaseUnidadesModulo> ProductosBaseUnidadesModulos { get; set; } = new List<ProductosBaseUnidadesModulo>();

    public virtual ICollection<ProductosUnidadesModulo> ProductosUnidadesModulos { get; set; } = new List<ProductosUnidadesModulo>();
}
