using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmClientesPunto
{
    public int PersonaId { get; set; }

    public int PuntosActuales { get; set; }

    public int PuntosAcumulados { get; set; }

    public int PuntosSobrantes { get; set; }

    public virtual ICollection<CrmClientesPuntosCabecera> CrmClientesPuntosCabeceras { get; set; } = new List<CrmClientesPuntosCabecera>();

    public virtual Cliente Persona { get; set; }
}
