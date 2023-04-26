using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RepHorasExtra
{
    public int EjercicioId { get; set; }

    public int OfAsuntosPropios { get; set; }

    public int OfVacaciones { get; set; }

    public int OfBajasLaborales { get; set; }

    public int OfBajas { get; set; }
}
