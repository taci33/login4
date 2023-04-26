using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesTelefono
{
    public int Id { get; set; }

    public int PersonaId { get; set; }

    public string Telefono { get; set; }

    public string Descripcion { get; set; }

    public int? PersonaDireccionId { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual ClientesDireccione PersonaDireccion { get; set; }
}
