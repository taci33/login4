using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosConjuntosComponente
{
    public int Idcomponente { get; set; }

    public int ConjuntoId { get; set; }

    public int ProductoTipoId { get; set; }

    public int ProductoId { get; set; }

    public string Nombre { get; set; }

    public int? LoteId { get; set; }

    public int? OperacionId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Cantidad { get; set; }

    public decimal Mermas { get; set; }

    public string Notas { get; set; }

    public virtual ProductosConjunto Conjunto { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual ProductosTipo ProductoTipo { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }

    public virtual UnidadesProducto UnidadesProducto { get; set; }
}
