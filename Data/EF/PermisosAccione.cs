using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PermisosAccione
{
    public int IdpermisoAccion { get; set; }

    public int PermisoCategoriaId { get; set; }

    public string Texto { get; set; }

    public int FormularioId { get; set; }

    public string Accion { get; set; }

    public bool? Enabled { get; set; }

    public int Orden { get; set; }

    public int? ClassFormIdp1 { get; set; }

    public int? ClassFormIdp2 { get; set; }

    public virtual Formulario ClassFormIdp1Navigation { get; set; }

    public virtual Formulario ClassFormIdp2Navigation { get; set; }

    public virtual Formulario Formulario { get; set; }

    public virtual PermisosCategoria PermisoCategoria { get; set; }

    public virtual ICollection<PermisosEmpleado> PermisosEmpleados { get; set; } = new List<PermisosEmpleado>();
}
