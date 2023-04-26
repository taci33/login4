﻿using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MovimientosAlmacenDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    /// <summary>
    /// 1 Entrada, 2 Salida, 3 Regularización
    /// </summary>
    public int TipoId { get; set; }

    public int ProductoId { get; set; }

    public int LoteId { get; set; }

    public int AlmacenId { get; set; }

    public int UbicacionId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Cantidad { get; set; }

    public double PrecioCoste { get; set; }

    public double DtoCoste { get; set; }

    public double PrecioCosteSinDto { get; set; }

    public virtual Almacene Almacen { get; set; }

    public virtual MovimientosAlmacen Cabecera { get; set; }

    public virtual ICollection<DocumentosGestionRegistroAlmacen> DocumentosGestionRegistroAlmacens { get; set; } = new List<DocumentosGestionRegistroAlmacen>();

    public virtual Lote Lote { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual MovimientosAlmacenTipo Tipo { get; set; }

    public virtual AlmacenesUbicacione Ubicacion { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }

    public virtual UnidadesProducto UnidadesProducto { get; set; }
}
