using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresProveedoresGrupo
{
    public int PersonaId { get; set; }

    public int GrupoId { get; set; }

    public virtual ProveedoresGrupo Grupo { get; set; }

    public virtual Proveedore Persona { get; set; }
}
