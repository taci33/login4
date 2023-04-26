using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class RegularizacionesAlmacen
{
    public Guid UidId { get; set; }

    public int ProductoId { get; set; }

    public int LoteId { get; set; }

    public int AlmacenId { get; set; }

    public int UbicacionId { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public double PrecioCompraMedio { get; set; }

    public double Stock { get; set; }

    public double? PrecioCompraMedioNuevo { get; set; }

    public double? StockNuevo { get; set; }

    public int? FamiliaId { get; set; }

    public string NombreProducto { get; set; }

    public string NombreLote { get; set; }

    public string CodigoPropio { get; set; }

    public virtual Almacene Almacen { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual AlmacenesUbicacione Ubicacion { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }
}
