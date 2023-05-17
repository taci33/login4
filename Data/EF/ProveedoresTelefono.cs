using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresTelefono
{
    public int Id { get; set; }

    public int PersonaId { get; set; }

    public string Telefono { get; set; }

    public string Descripcion { get; set; }

    public virtual Proveedore Persona { get; set; }
}
