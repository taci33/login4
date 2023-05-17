using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Temporada
{
    public int Idtemporada { get; set; }

    public string Nombre { get; set; }

    public bool Estado { get; set; }
}
