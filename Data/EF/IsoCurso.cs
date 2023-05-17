using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoCurso
{
    public int Idcurso { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int? PlanFormacionId { get; set; }

    public string Personal { get; set; }

    public int? DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public string Impartido { get; set; }

    public string Lugar { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? Duracion { get; set; }

    public bool Eficaz { get; set; }

    public virtual Departamento Departamento { get; set; }

    public virtual IsoPlanesFormacion PlanFormacion { get; set; }

    public virtual Seccione Seccion { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
