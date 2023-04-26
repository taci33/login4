using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosCompuesto
{
    public int ProductoCompuestoId { get; set; }

    public int? ProductoId { get; set; }

    public long? Idcdbo { get; set; }

    public string Descripcion { get; set; }

    public double Cantidad { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double PrecioVenta { get; set; }

    public decimal Descuento { get; set; }

    public decimal BaseImponible { get; set; }

    public int IdproductoCompuesto { get; set; }

    public int? ProductoBaseId { get; set; }

    public int? NumeroOrden { get; set; }

    public virtual ProductosCompuestosCdbo IdcdboNavigation { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Producto ProductoCompuesto { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }
}
