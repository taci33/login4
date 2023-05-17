using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class MovimientosAlmacen
{
    public int Idcabecera { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public DateTime Falta { get; set; }

    public string Titulo { get; set; }

    public int? DocumentoAlmacenTipoId { get; set; }

    public virtual DocumentosAlmacenTipo DocumentoAlmacenTipo { get; set; }

    public virtual ICollection<DocumentosGestionRegistroAlmacen> DocumentosGestionRegistroAlmacens { get; set; } = new List<DocumentosGestionRegistroAlmacen>();

    public virtual ICollection<MovimientosAlmacenDetalle> MovimientosAlmacenDetalles { get; set; } = new List<MovimientosAlmacenDetalle>();
}
