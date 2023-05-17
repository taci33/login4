using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoEncuesta
{
    public int Idencuesta { get; set; }

    public int PersonaId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? EncuestadorId { get; set; }

    public double? Valoracion { get; set; }

    public bool? Satisfaccion { get; set; }

    public string Observaciones { get; set; }

    public virtual Empleado Encuestador { get; set; }

    public virtual ICollection<IsoEncuestasDetalle> IsoEncuestasDetalles { get; set; } = new List<IsoEncuestasDetalle>();

    public virtual Cliente Persona { get; set; }
}
