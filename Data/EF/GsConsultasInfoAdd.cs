using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class GsConsultasInfoAdd
{
    public int Idgs { get; set; }

    public int ConsultaId { get; set; }

    public string Consulta { get; set; }

    public int AtributoId { get; set; }

    public string AtributoLabel { get; set; }
}
