using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ReservasStockDetalle
{
    public int Iddetalle { get; set; }

    public int CabeceraId { get; set; }

    public int LineaOrigenId { get; set; }

    public int ProductoId { get; set; }

    public int LoteId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Cantidad { get; set; }

    public double PrecioCoste { get; set; }

    public int AlmacenId { get; set; }

    public int UbicacionId { get; set; }

    public int AlmacenReservaId { get; set; }

    public int UbicacionReservaId { get; set; }

    public DateTime FechaInicioReserva { get; set; }

    public DateTime? FechaFinReserva { get; set; }

    public bool Finalizado { get; set; }

    public virtual Almacene Almacen { get; set; }

    public virtual Almacene AlmacenReserva { get; set; }

    public virtual AlmacenesUbicacione AlmacenesUbicacione { get; set; }

    public virtual AlmacenesUbicacione AlmacenesUbicacioneNavigation { get; set; }

    public virtual ReservasStock Cabecera { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Producto Producto { get; set; }
}
