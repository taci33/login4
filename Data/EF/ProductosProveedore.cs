using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosProveedore
{
    public int ProductoId { get; set; }

    public int PersonaId { get; set; }

    public string RefPersona { get; set; }

    public int? PlazosEntrega { get; set; }

    public double PrecioTarifa { get; set; }

    public double PrecioUltimaCompra { get; set; }

    public bool Tarifa { get; set; }

    public DateTime? FultimaCompra { get; set; }

    public double Precio { get; set; }

    public decimal Descuento { get; set; }

    public double CantidadDesde { get; set; }

    public double CantidadUltimaCompra { get; set; }

    public decimal DescuentoTarifa { get; set; }

    public double PrecioSinDtoTarifa { get; set; }

    /// <summary>
    /// Fecha de última actualización del PrecioTarifa
    /// </summary>
    public DateTime? Ftarifa { get; set; }

    /// <summary>
    /// Empleado que ha informado el precio de la Tarifa
    /// </summary>
    public int? EmpleadoIdtarifa { get; set; }
}
