using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresPeriodosExentosPago
{
    public int PersonaId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string Nombre { get; set; }

    public virtual Proveedore Persona { get; set; }
}
