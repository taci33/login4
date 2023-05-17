using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoProveedore
{
    public int PersonaId { get; set; }

    public string Descripcion { get; set; }

    public double? Valoracion { get; set; }

    public bool Homologado { get; set; }

    public bool SistCalidad { get; set; }

    public DateTime? FechaHomologacion { get; set; }

    public int? EmpleadoId { get; set; }

    public string ObservacionesCalidad { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Proveedore Persona { get; set; }
}
