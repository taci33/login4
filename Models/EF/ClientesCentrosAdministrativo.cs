using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesCentrosAdministrativo
{
    public int IdcentroAdministrativo { get; set; }

    public int PersonaId { get; set; }

    /// <summary>
    /// Organo Gestor Nombre
    /// </summary>
    public string OgNombre { get; set; }

    /// <summary>
    /// Organo Gestor Código
    /// </summary>
    public string OgCodigo { get; set; }

    /// <summary>
    /// Unidad Tramitadora Nombre
    /// </summary>
    public string UtNombre { get; set; }

    /// <summary>
    /// Unidad Tramitadora Código
    /// </summary>
    public string UtCodigo { get; set; }

    /// <summary>
    /// Oficina Contable Nombre
    /// </summary>
    public string OcNombre { get; set; }

    /// <summary>
    /// Oficina Contable Código
    /// </summary>
    public string OcCodigo { get; set; }

    public virtual Cliente Persona { get; set; }
}
