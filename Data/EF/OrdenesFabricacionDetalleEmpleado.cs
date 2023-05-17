using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesFabricacionDetalleEmpleado
{
    public int Idofde { get; set; }

    public int CabeceraId { get; set; }

    public int LineaId { get; set; }

    public int EmpleadoId { get; set; }

    public int? PuestoId { get; set; }

    public virtual OrdenesFabricacion Cabecera { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual OrdenesFabricacionDetalle Linea { get; set; }

    public virtual Puesto Puesto { get; set; }
}
