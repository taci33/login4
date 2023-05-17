using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FichajesTareasStandBy
{
    public int FichajeParteId { get; set; }

    public int PersonaId { get; set; }

    public virtual FichajesParte FichajeParte { get; set; }

    public virtual Empleado Persona { get; set; }
}
