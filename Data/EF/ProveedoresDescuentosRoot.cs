using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresDescuentosRoot
{
    public int IdpersonaPt { get; set; }

    public int PersonaId { get; set; }

    public int ProductoTipoId { get; set; }

    public decimal Descuento { get; set; }

    public virtual Proveedore Persona { get; set; }

    public virtual ProductosTipo ProductoTipo { get; set; }
}
