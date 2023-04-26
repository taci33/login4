using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Pgc
{
    public string Cuenta { get; set; }

    public string Descripcion { get; set; }

    public byte Nivel { get; set; }

    public virtual ICollection<ConceptosRetencion> ConceptosRetencionCtaComprasNavigations { get; set; } = new List<ConceptosRetencion>();

    public virtual ICollection<ConceptosRetencion> ConceptosRetencionCtaVentasNavigations { get; set; } = new List<ConceptosRetencion>();

    public virtual ICollection<Diario> Diarios { get; set; } = new List<Diario>();

    public virtual ICollection<IvaLibroRepercutido> IvaLibroRepercutidos { get; set; } = new List<IvaLibroRepercutido>();

    public virtual ICollection<IvaLibroSoportado> IvaLibroSoportados { get; set; } = new List<IvaLibroSoportado>();
}
