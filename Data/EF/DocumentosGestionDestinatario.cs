using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestionDestinatario
{
    public int IddocumentoGestionDestinatario { get; set; }

    public string NombreEntidad { get; set; }

    public string NombreEntidadSingular { get; set; }

    public string TableName { get; set; }

    public virtual ICollection<DocumentosGestion> DocumentosGestions { get; set; } = new List<DocumentosGestion>();

    public virtual ICollection<IsoComunicacione> IsoComunicacioneTipoDestDemanda { get; set; } = new List<IsoComunicacione>();

    public virtual ICollection<IsoComunicacione> IsoComunicacioneTipoDestRespuesta { get; set; } = new List<IsoComunicacione>();

    public virtual ICollection<IsoIncidencia> IsoIncidencia { get; set; } = new List<IsoIncidencia>();

    public virtual ICollection<IsoTiposIncidencia> IsoTiposIncidencia { get; set; } = new List<IsoTiposIncidencia>();

    public virtual ICollection<IsoVencimiento> IsoVencimientos { get; set; } = new List<IsoVencimiento>();
}
