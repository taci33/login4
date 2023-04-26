using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosBase
{
    public int IdproductoBase { get; set; }

    public int? EmpresaId { get; set; }

    public int? FamiliaId { get; set; }

    public int? MarcaId { get; set; }

    public int ProductoTipoId { get; set; }

    public int ProductoEstadoId { get; set; }

    public string ReferenciaProveedor { get; set; }

    public string CodigoBarras { get; set; }

    public string CodigoPropio { get; set; }

    public string Nombre { get; set; }

    public DateTime Falta { get; set; }

    public DateTime? Fbaja { get; set; }

    public double StockMin { get; set; }

    public double StockMax { get; set; }

    public double StockActual { get; set; }

    public double StockPedido { get; set; }

    public bool StockNegativo { get; set; }

    public double PrecioCompra { get; set; }

    public double PrecioVenta { get; set; }

    public double PrecioCompraMedio { get; set; }

    public double PrecioVentaMedio { get; set; }

    public string Notas { get; set; }

    public bool GestLotes { get; set; }

    public bool? GestStock { get; set; }

    public bool GestAlmacen { get; set; }

    public bool GestMargen { get; set; }

    public double? Margen { get; set; }

    public int IvaclaseId { get; set; }

    public int? TemporadaId { get; set; }

    public string Descripcion { get; set; }

    public double Pvp { get; set; }

    public string CtaCompras { get; set; }

    public string CtaVentas { get; set; }

    public int? CentroCosteId { get; set; }

    public long? Idcdbo { get; set; }

    public int MargenTipoId { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual Familia Familia { get; set; }

    public virtual ProductosBaseCdbo IdcdboNavigation { get; set; }

    public virtual Marca Marca { get; set; }

    public virtual MargenesTipo MargenTipo { get; set; }

    public virtual ProductosEstado ProductoEstado { get; set; }

    public virtual ProductosTipo ProductoTipo { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<UnidadesProductoBase> UnidadesProductoBases { get; set; } = new List<UnidadesProductoBase>();
}
