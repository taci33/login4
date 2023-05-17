using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LabOasLectura
{
    public int Idlectura { get; set; }

    public int LineaId { get; set; }

    public int EstadoId { get; set; }

    public DateTime Freal { get; set; }

    public int? ResponsableId { get; set; }

    public string Resultado { get; set; }

    public string Observaciones { get; set; }

    public string Resultado2 { get; set; }

    public string Resultado3 { get; set; }

    public string Resultado4 { get; set; }

    public virtual LabOasLecturasEstado Estado { get; set; }

    public virtual LabOasDetalle Linea { get; set; }

    public virtual Empleado Responsable { get; set; }
}
