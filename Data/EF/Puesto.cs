using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Puesto
{
    public int Idpuesto { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int? DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public string Funciones { get; set; }

    public string Perfil { get; set; }

    public string Formacion { get; set; }

    public virtual Departamento Departamento { get; set; }

    public virtual ICollection<IsoActividadesPersonal> IsoActividadesPersonals { get; set; } = new List<IsoActividadesPersonal>();

    public virtual ICollection<Maquina> Maquinas { get; set; } = new List<Maquina>();

    public virtual ICollection<OrdenesFabricacionDetalleEmpleado> OrdenesFabricacionDetalleEmpleados { get; set; } = new List<OrdenesFabricacionDetalleEmpleado>();

    public virtual Seccione Seccion { get; set; }

    public virtual ICollection<IsoDocumento> Documentos { get; set; } = new List<IsoDocumento>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<IsoRequisito> Requisitos { get; set; } = new List<IsoRequisito>();
}
