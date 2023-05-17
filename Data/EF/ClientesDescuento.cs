using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesDescuento
{
    public int PersonaId { get; set; }

    public int FamiliaId { get; set; }

    public decimal Descuento { get; set; }

    public bool ApplySubfamilias { get; set; }

    public virtual Familia Familia { get; set; }

    public virtual Cliente Persona { get; set; }
}
