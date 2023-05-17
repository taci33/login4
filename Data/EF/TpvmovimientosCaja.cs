using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TpvmovimientosCaja
{
    public int IdtpvmovimientoCaja { get; set; }

    public int CabeceraId { get; set; }

    public int Tpvid { get; set; }

    public int? TpvformaPagoId { get; set; }

    public int EmpleadoId { get; set; }

    public decimal? CantidadEntra { get; set; }

    public decimal? CantidadSale { get; set; }

    public DateTime? FechaHora { get; set; }

    public int? TipoMovimiento { get; set; }

    public bool EntregaAcuenta { get; set; }

    public virtual Tpvticket Cabecera { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Tpv Tpv { get; set; }
}
