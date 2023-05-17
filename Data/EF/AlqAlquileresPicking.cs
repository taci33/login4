using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlqAlquileresPicking
{
    public int Idpicking { get; set; }

    public int CabeceraId { get; set; }

    public int TipoId { get; set; }

    public DateTime Falta { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EstadoId { get; set; }

    public virtual ICollection<AlqAlquileresDetallePicking> AlqAlquileresDetallePickingPickingEntrada { get; set; } = new List<AlqAlquileresDetallePicking>();

    public virtual ICollection<AlqAlquileresDetallePicking> AlqAlquileresDetallePickingPickingSalida { get; set; } = new List<AlqAlquileresDetallePicking>();

    public virtual AlqAlquilere Cabecera { get; set; }

    public virtual AlqAlquileresPickingTipo Tipo { get; set; }
}
