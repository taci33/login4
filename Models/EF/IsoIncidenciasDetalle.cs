using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoIncidenciasDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    public int? Numero { get; set; }

    public int TipoAccionId { get; set; }

    public string Accion { get; set; }

    public DateTime? FechaPrevista { get; set; }

    public DateTime? FechaRealizacion { get; set; }

    public bool? Evaluado { get; set; }

    public bool? Eficaz { get; set; }

    public int? EmpleadoId { get; set; }

    public virtual IsoIncidencia Cabecera { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual IsoTiposAccione TipoAccion { get; set; }
}
