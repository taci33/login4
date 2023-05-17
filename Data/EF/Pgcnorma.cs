using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Pgcnorma
{
    public string Naturaleza { get; set; }

    public string Codbal { get; set; }

    public string Descrip { get; set; }

    public string Cta { get; set; }

    public short? Tipo { get; set; }

    public string Bitmap { get; set; }

    public string Doble { get; set; }

    public string Formula { get; set; }

    public short? Nivel { get; set; }

    public short? Desglose { get; set; }

    public string Acpa { get; set; }

    public string Numero { get; set; }
}
