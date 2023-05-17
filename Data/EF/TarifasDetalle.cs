using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class TarifasDetalle
{
    public int IdtarifaDetalle { get; set; }

    public int TarifaId { get; set; }

    public int ProductoId { get; set; }

    public string Descripcion { get; set; }

    public double CantidadDesde { get; set; }

    /// <summary>
    /// 1 &gt; Fijo, 2 &gt; Margen
    /// </summary>
    public int CalculoTipo { get; set; }

    /// <summary>
    /// Coste ·ltima Entrada, Coste Medio, Precio Venta
    /// </summary>
    public int? MargenOrigen { get; set; }

    /// <summary>
    /// %, +
    /// </summary>
    public int? MargenOperacion { get; set; }

    /// <summary>
    /// % o importe seg·n Margen_Operacion
    /// </summary>
    public double Margen { get; set; }

    public double PrecioVenta { get; set; }

    public double Pvp { get; set; }

    public decimal Descuento { get; set; }

    public DateTime? FechaUltimaActualizacion { get; set; }

    public bool MargenCosteAdicional { get; set; }

    public int? MargenCosteAdicionalOperacion { get; set; }

    public double? MargenCosteAdicionalMargen { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Tarifa Tarifa { get; set; }
}
