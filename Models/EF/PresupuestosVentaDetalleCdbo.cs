using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PresupuestosVentaDetalleCdbo
{
    /// <summary>
    /// Hace referencia a la tabla de la que cuelga y es igual a la clave IDCDBO de esa tabla
    /// </summary>
    public long Idcdbo { get; set; }

    public string ProcedimientoEnsayo { get; set; }

    public string TecnicaAnalisis { get; set; }

    public string Unidades { get; set; }

    public string LimiteCuantificacion { get; set; }

    public string LimiteDeteccion { get; set; }

    public string ValorParametrico { get; set; }

    public double TiempoMaximo { get; set; }

    public double TiempoEspera { get; set; }

    public string Acondicionamiento { get; set; }

    public string Envase { get; set; }

    public decimal? Incertidumbre { get; set; }

    public string LimiteMaximo { get; set; }

    public bool Acreditado { get; set; }

    public int? ProductoCompuestoId { get; set; }

    public string Frecuencia { get; set; }

    public string Legislacion { get; set; }

    public int? ProcedimientoEnsayoId { get; set; }

    public virtual PresupuestosVentaDetalle PresupuestosVentaDetalle { get; set; }

    public virtual LabProcedimientosEnsayo ProcedimientoEnsayoNavigation { get; set; }

    public virtual Producto ProductoCompuesto { get; set; }
}
