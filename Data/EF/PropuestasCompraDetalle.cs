using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PropuestasCompraDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    public int CabeceraOrigenId { get; set; }

    public int LineaOrigenId { get; set; }

    public DateTime Fnecesidad { get; set; }

    public double StockNecesidad { get; set; }

    public double CantidadPendiente { get; set; }

    public double CantidadPedido { get; set; }

    /// <summary>
    /// Marca si el registro ha sido seleccionado para pasar a la 2ª pantalla.
    /// </summary>
    public bool Seleccionado { get; set; }

    public int? ProveedorId { get; set; }

    public int ProductoId { get; set; }

    public int? LoteId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public string Descripcion { get; set; }

    public virtual PropuestasCompra Cabecera { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Proveedore Proveedor { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }
}
