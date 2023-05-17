using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Almacene
{
    public int Idalmacen { get; set; }

    public string Nombre { get; set; }

    public string Direccion { get; set; }

    public string CodigoPostal { get; set; }

    public int? LocalidadId { get; set; }

    public int? ProvinciaId { get; set; }

    public int? PaisId { get; set; }

    public bool AutogenerarNombreUbicaciones { get; set; }

    public string PalabraBaseUbicaciones { get; set; }

    public bool IsVirtual { get; set; }

    public bool DepositoOpe { get; set; }

    public int? CentroId { get; set; }

    public bool? IsReserva { get; set; }

    public virtual ICollection<AlmacenesUbicacione> AlmacenesUbicaciones { get; set; } = new List<AlmacenesUbicacione>();

    public virtual ICollection<BienesAmortizable> BienesAmortizables { get; set; } = new List<BienesAmortizable>();

    public virtual CentrosTrabajo Centro { get; set; }

    public virtual ICollection<DgdUbicacione> DgdUbicaciones { get; set; } = new List<DgdUbicacione>();

    public virtual ICollection<DocumentosGestionDetalleUbicacione> DocumentosGestionDetalleUbicaciones { get; set; } = new List<DocumentosGestionDetalleUbicacione>();

    public virtual ICollection<MovimientosAlmacenDetalle> MovimientosAlmacenDetalles { get; set; } = new List<MovimientosAlmacenDetalle>();

    public virtual ICollection<MovimientosAlmacenSaldo> MovimientosAlmacenSaldos { get; set; } = new List<MovimientosAlmacenSaldo>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual ICollection<RegularizacionesAlmacen> RegularizacionesAlmacens { get; set; } = new List<RegularizacionesAlmacen>();

    public virtual ICollection<ReservasStockDetalle> ReservasStockDetalleAlmacenReservas { get; set; } = new List<ReservasStockDetalle>();

    public virtual ICollection<ReservasStockDetalle> ReservasStockDetalleAlmacens { get; set; } = new List<ReservasStockDetalle>();
}
