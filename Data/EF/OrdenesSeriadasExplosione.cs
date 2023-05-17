using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OrdenesSeriadasExplosione
{
    public int Idexplosion { get; set; }

    public int? ExplosionId { get; set; }

    /// <summary>
    /// Columna auxiliar para construir el árbol -&gt; Apunta al primer IDExplosion de cada Explosion. Parecido a un identificador de sesión.
    /// </summary>
    public int? ExplosionSessionId { get; set; }

    /// <summary>
    /// AuxMakeExplosion -&gt; Auxiliar para la construcción del árbol de explosión
    /// </summary>
    public int AmeTreeLevel { get; set; }

    public int? Idconjunto { get; set; }

    public int? ConjuntoId { get; set; }

    public int ProductoId { get; set; }

    public double Cantidad { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public int? OrdenSeriadaId { get; set; }

    public int? RutaId { get; set; }

    public bool GenerarOrdenSeriada { get; set; }

    public int? EjercicioId { get; set; }

    public DateTime? Falta { get; set; }

    public string Titulo { get; set; }

    public int? SerieId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual OrdenesSeriadasExplosione Explosion { get; set; }

    public virtual OrdenesSeriadasExplosione ExplosionSession { get; set; }

    public virtual ICollection<OrdenesSeriadasExplosione> InverseExplosion { get; set; } = new List<OrdenesSeriadasExplosione>();

    public virtual ICollection<OrdenesSeriadasExplosione> InverseExplosionSession { get; set; } = new List<OrdenesSeriadasExplosione>();

    public virtual Series Serie { get; set; }
}
