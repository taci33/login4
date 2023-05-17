using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RrhhPrimasLiquidacion
{
    public int Idcabecera { get; set; }

    public DateTime Falta { get; set; }

    public int PersonaId { get; set; }

    public int EstadoId { get; set; }

    public int EjercicioId { get; set; }

    public string Anno { get; set; }

    public int Mes { get; set; }

    public string Codigo { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public string Observaciones { get; set; }

    public int LaborablesMes { get; set; }

    public int CotizacionPerCent { get; set; }

    public DateTime? Fliquidacion { get; set; }

    public double NumHorasNormal { get; set; }

    public double NumHorasExtra { get; set; }

    public double NumHorasExtraFestivo { get; set; }

    public double NumHorasA { get; set; }

    public double NumHorasReten { get; set; }

    public double NumHorasTotal { get; set; }

    public double NumDietas { get; set; }

    public double NumKilometros { get; set; }

    public double NumServicioReten { get; set; }

    public double NumFestivoTrabajado { get; set; }

    public double NumCompensacionFestivo { get; set; }

    public double NumVacaciones { get; set; }

    public double NumPermiso { get; set; }

    public double NumEnfermedad { get; set; }

    public double NumAccidente { get; set; }

    public double NumLaborablesTrabajados { get; set; }

    public decimal PrecioHoraExtra { get; set; }

    public decimal PrecioHoraExtraFestivo { get; set; }

    public decimal PrimaLaborable { get; set; }

    public decimal PrimaFestivo { get; set; }

    public decimal PrimaCompensacionFestivo { get; set; }

    public decimal PrimaMensual { get; set; }

    public decimal PrimaHoraReten { get; set; }

    public decimal PrimaServicioReten { get; set; }

    public decimal PrecioDieta { get; set; }

    public decimal PrecioKilometro { get; set; }

    public decimal TotalHorasExtra { get; set; }

    public decimal TotalHorasExtraFestivo { get; set; }

    public decimal TotalHorasReten { get; set; }

    public decimal TotalHorasA { get; set; }

    public decimal TotalKilometros { get; set; }

    public decimal TotalDietas { get; set; }

    public decimal TotalServicioReten { get; set; }

    public decimal TotalPrimaLaborable { get; set; }

    public decimal TotalPrimaFestivo { get; set; }

    public decimal TotalPrimaCompensacionFestivo { get; set; }

    public decimal TotalPrimaMensual { get; set; }

    public decimal Otros { get; set; }

    public decimal TotalDevengado { get; set; }

    public decimal ImporteNominaTotalActividad { get; set; }

    public decimal ImporteNominaNumHorasExtra { get; set; }

    public decimal ImporteNominaTotalHorasExtra { get; set; }

    public decimal ImporteNominaKilometros { get; set; }

    public decimal ImporteNominaTotalKilometros { get; set; }

    public decimal ImporteNominaTotalDietas { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual RrhhPrimasLiquidacionEstado Estado { get; set; }

    public virtual Empleado Persona { get; set; }

    public virtual ICollection<RrhhPrimasLiquidacionDetalle> RrhhPrimasLiquidacionDetalles { get; set; } = new List<RrhhPrimasLiquidacionDetalle>();
}
