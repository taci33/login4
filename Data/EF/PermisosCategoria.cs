using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PermisosCategoria
{
    public int IdpermisoCategoria { get; set; }

    public int? ModuloGestionId { get; set; }

    public string Nombre { get; set; }

    public int SortOrder { get; set; }

    public int? PermisoCategoriaId { get; set; }

    public int AplicacionId { get; set; }

    public virtual ModulosGestion ModuloGestion { get; set; }

    public virtual ICollection<PermisosAccione> PermisosAcciones { get; set; } = new List<PermisosAccione>();
}
