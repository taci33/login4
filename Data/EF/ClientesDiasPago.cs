using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesDiasPago
{
    public int PersonaId { get; set; }

    public int DiaInicio { get; set; }

    public int DiaFin { get; set; }

    public virtual Cliente Persona { get; set; }
}
