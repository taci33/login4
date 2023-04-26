using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Departamento
{
    public int Iddepartamento { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<CtaCentroCoste> CtaCentroCostes { get; set; } = new List<CtaCentroCoste>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<IsoActividadesPersonal> IsoActividadesPersonals { get; set; } = new List<IsoActividadesPersonal>();

    public virtual ICollection<IsoCurso> IsoCursos { get; set; } = new List<IsoCurso>();

    public virtual ICollection<IsoIncidencia> IsoIncidencia { get; set; } = new List<IsoIncidencia>();

    public virtual ICollection<IsoIndicadore> IsoIndicadores { get; set; } = new List<IsoIndicadore>();

    public virtual ICollection<IsoRevisione> IsoRevisiones { get; set; } = new List<IsoRevisione>();

    public virtual ICollection<Maquina> Maquinas { get; set; } = new List<Maquina>();

    public virtual ICollection<Puesto> Puestos { get; set; } = new List<Puesto>();

    public virtual ICollection<Seccione> Secciones { get; set; } = new List<Seccione>();
}
