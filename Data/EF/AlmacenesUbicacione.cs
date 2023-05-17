using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlmacenesUbicacione
{
    public int Idubicacion { get; set; }

    public int? UbicacionId { get; set; }

    public int AlmacenId { get; set; }

    public string Nombre { get; set; }

    public int Nivel { get; set; }

    public virtual Almacene Almacen { get; set; }

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();

    public virtual ICollection<DgdUbicacione> DgdUbicaciones { get; set; } = new List<DgdUbicacione>();

    public virtual ICollection<DocumentosGestionDetalleUbicacione> DocumentosGestionDetalleUbicaciones { get; set; } = new List<DocumentosGestionDetalleUbicacione>();

    public virtual ICollection<AlmacenesUbicacione> InverseUbicacion { get; set; } = new List<AlmacenesUbicacione>();

    public virtual ICollection<MovimientosAlmacenDetalle> MovimientosAlmacenDetalles { get; set; } = new List<MovimientosAlmacenDetalle>();

    public virtual ICollection<MovimientosAlmacenSaldo> MovimientosAlmacenSaldos { get; set; } = new List<MovimientosAlmacenSaldo>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual ICollection<ProductosAlmacen> ProductosAlmacens { get; set; } = new List<ProductosAlmacen>();

    public virtual ICollection<ProductosTipo> ProductosTipos { get; set; } = new List<ProductosTipo>();

    public virtual ICollection<RegularizacionesAlmacen> RegularizacionesAlmacens { get; set; } = new List<RegularizacionesAlmacen>();

    public virtual ICollection<ReservasStockDetalle> ReservasStockDetalleAlmacenesUbicacioneNavigations { get; set; } = new List<ReservasStockDetalle>();

    public virtual ICollection<ReservasStockDetalle> ReservasStockDetalleAlmacenesUbicaciones { get; set; } = new List<ReservasStockDetalle>();

    public virtual ICollection<Tpv> Tpvs { get; set; } = new List<Tpv>();

    public virtual AlmacenesUbicacione Ubicacion { get; set; }
}
