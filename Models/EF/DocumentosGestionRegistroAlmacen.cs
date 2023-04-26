using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestionRegistroAlmacen
{
    public int DocumentoGestionOrigenId { get; set; }

    public int CabeceraOrigenId { get; set; }

    public int DetalleOrigenId { get; set; }

    public int? DgduId { get; set; }

    public int DocumentoGestionDestinoId { get; set; }

    public int CabeceraDestinoId { get; set; }

    public int DetalleDestinoId { get; set; }

    public virtual MovimientosAlmacen CabeceraDestino { get; set; }

    public virtual MovimientosAlmacenDetalle DetalleDestino { get; set; }

    public virtual DocumentosGestion DocumentoGestionDestino { get; set; }

    public virtual DocumentosGestion DocumentoGestionOrigen { get; set; }
}
