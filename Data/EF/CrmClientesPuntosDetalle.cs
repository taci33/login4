using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmClientesPuntosDetalle
{
    public int Idlinea { get; set; }

    public int CabeceraId { get; set; }

    public int DocumentoGestionLineaId { get; set; }

    public int ProductoId { get; set; }

    public string Descripcion { get; set; }

    public decimal Importe { get; set; }

    public int Puntos { get; set; }

    public int PuntosTablaId { get; set; }

    public int? PuntosTablaDetalleId { get; set; }

    public virtual CrmClientesPuntosCabecera Cabecera { get; set; }

    public virtual CrmPuntosTablaDetalle CrmPuntosTablaDetalle { get; set; }

    public virtual CrmPuntosTabla PuntosTabla { get; set; }
}
