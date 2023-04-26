using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RrhhPrimasLiquidacionDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    public int TipoLineaId { get; set; }

    public DateTime Falta { get; set; }

    public int TurnoId { get; set; }

    public int? EmpleadoId { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime FultimaModificacion { get; set; }

    public double NumHorasNormal { get; set; }

    public double NumHorasExtra { get; set; }

    public double NumHorasExtraFestivo { get; set; }

    public double NumHorasReten { get; set; }

    public double NumHorasTotal { get; set; }

    public double NumHorasA { get; set; }

    public double NumDieta { get; set; }

    public double NumKilometros { get; set; }

    public double ServicioReten { get; set; }

    public double Festivo { get; set; }

    public double CompensacionFestivo { get; set; }

    public double Vacaciones { get; set; }

    public double Permiso { get; set; }

    public double Enfermedad { get; set; }

    public double Accidente { get; set; }

    public string Observaciones { get; set; }

    public virtual RrhhPrimasLiquidacion Cabecera { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }

    public virtual Turno Turno { get; set; }
}
