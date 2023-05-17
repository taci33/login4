using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Diario
{
    public int EjercicioId { get; set; }

    public int Asiento { get; set; }

    public int Apunte { get; set; }

    public DateTime Fecha { get; set; }

    public int? Anno { get; set; }

    public string Cuenta { get; set; }

    public string Concepto { get; set; }

    public string Dh { get; set; }

    public decimal Importe { get; set; }

    public double? TipoIva { get; set; }

    public string Incidencia { get; set; }

    public bool Descuadre { get; set; }

    public string Factura { get; set; }

    public int? IvagrupoId { get; set; }

    public int? FacturaId { get; set; }

    public decimal? Re { get; set; }

    public decimal? BaseImponible { get; set; }

    public decimal? ImporteRe { get; set; }

    public int? VencimientoId { get; set; }

    public int? RemesaId { get; set; }

    public int? CentroCosteId { get; set; }

    public int? OrigenId { get; set; }

    public int? CabeceraOrigenId { get; set; }

    public DateTime Falta { get; set; }

    public bool ExcluirListadosEnabled { get; set; }

    public bool Punteado { get; set; }

    public int Iddiario { get; set; }

    public bool Exportado { get; set; }

    public DateTime? FechaExp { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual Pgc CuentaNavigation { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual CtaAsientosOrigene Origen { get; set; }
}
