using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoActividadesPersonal
{
    public int IdactividadPersonal { get; set; }

    public int ActividadId { get; set; }

    public int? DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public int? PuestoId { get; set; }

    public int? EmpleadoId { get; set; }

    public virtual IsoActividade Actividad { get; set; }

    public virtual Departamento Departamento { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Puesto Puesto { get; set; }

    public virtual Seccione Seccion { get; set; }
}
