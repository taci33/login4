using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoActividade
{
    public int Idactividad { get; set; }

    public string Nombre { get; set; }

    public int ProcesoId { get; set; }

    public int? ActividadId { get; set; }

    public int Orden { get; set; }

    public virtual IsoActividade Actividad { get; set; }

    public virtual ICollection<IsoActividade> InverseActividad { get; set; } = new List<IsoActividade>();

    public virtual ICollection<IsoActividadesPersonal> IsoActividadesPersonals { get; set; } = new List<IsoActividadesPersonal>();

    public virtual IsoProceso Proceso { get; set; }

    public virtual ICollection<Maquina> Maquinas { get; set; } = new List<Maquina>();
}
