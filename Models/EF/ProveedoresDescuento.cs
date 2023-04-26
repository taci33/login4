using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresDescuento
{
    public int IdpersonaFamilia { get; set; }

    public int PersonaId { get; set; }

    public int FamiliaId { get; set; }

    public decimal Descuento { get; set; }

    public bool ApplySubFamilias { get; set; }

    public virtual Familia Familia { get; set; }

    public virtual Proveedore Persona { get; set; }
}
