using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IvaLibroRepercutido
{
    public int Clave { get; set; }

    public int EjercicioId { get; set; }

    public int? Asiento { get; set; }

    public string CtaConta { get; set; }

    public string Nombre { get; set; }

    public string Nif { get; set; }

    public string Factura { get; set; }

    public DateTime? Fecha { get; set; }

    public string Descripcion { get; set; }

    public decimal? Base { get; set; }

    public double? PorcentajeIva { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Total { get; set; }

    public int? AsientoAntiguo { get; set; }

    public string CuentaIva { get; set; }

    public double? PorcentajeRe { get; set; }

    public decimal? Re { get; set; }

    public double? PorcentajeRet { get; set; }

    public decimal? Retencion { get; set; }

    public string CuentaRet { get; set; }

    public int? IvagrupoId { get; set; }

    public bool? Abono { get; set; }

    public int? TipoClaveId { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public int NifTipo { get; set; }

    public string FacturaRectificada { get; set; }

    public bool SiiExportado { get; set; }

    public string ClaveTipoFactura { get; set; }

    public string RectificativaClave { get; set; }

    public string ClaveTributariaOperacion { get; set; }

    public string DescripcionOperacion { get; set; }

    public string InmuebleSituacion { get; set; }

    public string InmuebleReferenciaCatastral { get; set; }

    public string ActividadTipo { get; set; }

    public string ActividadGrupo { get; set; }

    public string Concepto { get; set; }

    public bool? OperacionCriterioCaja { get; set; }

    public decimal? IrpfRetencion { get; set; }

    public decimal? IrpfImporte { get; set; }

    public decimal? Computable { get; set; }

    public virtual Pgc CtaContaNavigation { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual IvaLibroTipoClave TipoClave { get; set; }
}
