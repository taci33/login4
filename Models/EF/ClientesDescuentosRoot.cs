using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesDescuentosRoot
{
    public int PersonaId { get; set; }

    public int ProductoTipoId { get; set; }

    public decimal Descuento { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual ProductosTipo ProductoTipo { get; set; }
}
