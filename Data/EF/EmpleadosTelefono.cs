using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EmpleadosTelefono
{
    public int IdempleadoTelefono { get; set; }

    public int EmpleadoId { get; set; }

    public string Telefono { get; set; }

    public string Descripcion { get; set; }

    public virtual Empleado Empleado { get; set; }
}
