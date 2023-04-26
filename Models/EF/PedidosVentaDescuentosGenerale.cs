using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PedidosVentaDescuentosGenerale
{
    public int Iddescuento { get; set; }

    public int CabeceraId { get; set; }

    public int? ProductoTipoId { get; set; }

    public int? TipoLineaId { get; set; }

    public decimal Descuento { get; set; }

    public decimal Importe { get; set; }

    public bool Acumular { get; set; }

    public virtual PedidosVentum Cabecera { get; set; }

    public virtual ProductosTipo ProductoTipo { get; set; }

    public virtual TiposLinea TipoLinea { get; set; }
}
