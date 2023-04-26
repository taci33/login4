using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmPuntosTabla
{
    public int IdpuntosTabla { get; set; }

    public string Nombre { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int Tipo { get; set; }

    public decimal ValorFijo { get; set; }

    public virtual ICollection<CrmClientesPuntosDetalle> CrmClientesPuntosDetalles { get; set; } = new List<CrmClientesPuntosDetalle>();

    public virtual ICollection<CrmPuntosTablaDetalle> CrmPuntosTablaDetalles { get; set; } = new List<CrmPuntosTablaDetalle>();
}
