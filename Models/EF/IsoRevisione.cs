using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoRevisione
{
    public int Idrevision { get; set; }

    public DateTime? FechaRevision { get; set; }

    public int? DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public string Temas { get; set; }

    public virtual Departamento Departamento { get; set; }

    public virtual ICollection<IsoRevisionesAcuerdo> IsoRevisionesAcuerdos { get; set; } = new List<IsoRevisionesAcuerdo>();

    public virtual Seccione Seccion { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
