using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlqAlquileresDetallePicking
{
    public int IdpickingDetalle { get; set; }

    public int CabeceraId { get; set; }

    public bool EnDocumento { get; set; }

    public int? PickingSalidaId { get; set; }

    public int? PickingEntradaId { get; set; }

    public int ProductoId { get; set; }

    public double CantidadAlquiler { get; set; }

    public double CantidadSalida { get; set; }

    /// <summary>
    /// Determina si la línea se la Cantidad se ha informado de forma automática (sin lectura)
    /// </summary>
    public bool CantidadSalidaAuto { get; set; }

    public double CantidadEntrada { get; set; }

    /// <summary>
    /// Determina si la línea se la Cantidad se ha informado de forma automática (sin lectura)
    /// </summary>
    public bool CantidadEntradaAuto { get; set; }

    public string Observaciones { get; set; }

    public virtual AlqAlquilere Cabecera { get; set; }

    public virtual AlqAlquileresPicking PickingEntrada { get; set; }

    public virtual AlqAlquileresPicking PickingSalida { get; set; }
}
