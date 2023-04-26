using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProductosConjunto
{
    public int Idconjunto { get; set; }

    public int ProductoId { get; set; }

    public string Nombre { get; set; }

    public int? LoteId { get; set; }

    public double CantidadMinima { get; set; }

    public double CantidadAgrupacion { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public int? RutaId { get; set; }

    public decimal PorcentajeDefectuosos { get; set; }

    public string Notas { get; set; }

    public int? ParteFormularioId { get; set; }

    public virtual ICollection<OrdenesSeriada> OrdenesSeriada { get; set; } = new List<OrdenesSeriada>();

    public virtual PartesFormulario ParteFormulario { get; set; }

    public virtual ICollection<ProductosConjuntosComponente> ProductosConjuntosComponentes { get; set; } = new List<ProductosConjuntosComponente>();

    public virtual ICollection<ProductosConjuntosDatosDinamico> ProductosConjuntosDatosDinamicos { get; set; } = new List<ProductosConjuntosDatosDinamico>();

    public virtual UnidadesMedidum UnidadMedida { get; set; }

    public virtual UnidadesProducto UnidadesProducto { get; set; }
}
