using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Seccione
{
    public int Idseccion { get; set; }

    public string Nombre { get; set; }

    public int? SeccionId { get; set; }

    public int DepartamentoId { get; set; }

    public virtual ICollection<CtaCentroCoste> CtaCentroCostes { get; set; } = new List<CtaCentroCoste>();

    public virtual Departamento Departamento { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<Seccione> InverseSeccion { get; set; } = new List<Seccione>();

    public virtual ICollection<IsoActividadesPersonal> IsoActividadesPersonals { get; set; } = new List<IsoActividadesPersonal>();

    public virtual ICollection<IsoCurso> IsoCursos { get; set; } = new List<IsoCurso>();

    public virtual ICollection<IsoIncidencia> IsoIncidencia { get; set; } = new List<IsoIncidencia>();

    public virtual ICollection<IsoIndicadore> IsoIndicadores { get; set; } = new List<IsoIndicadore>();

    public virtual ICollection<IsoRevisione> IsoRevisiones { get; set; } = new List<IsoRevisione>();

    public virtual ICollection<Maquina> Maquinas { get; set; } = new List<Maquina>();

    public virtual ICollection<Puesto> Puestos { get; set; } = new List<Puesto>();

    public virtual Seccione Seccion { get; set; }
}
