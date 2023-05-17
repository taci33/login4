using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VPartesOfmat
{
    public int DocumentoId { get; set; }

    public string NombreSpa { get; set; }

    public string Expr1 { get; set; }

    public int Idparte { get; set; }

    public DateTime? FechaImputacion { get; set; }

    public string Nombre { get; set; }

    public string Observaciones { get; set; }
}
