using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmSegmento
{
    public int Idsegmento { get; set; }

    public string Nombre { get; set; }

    public bool Contacto { get; set; }

    public int UsrTypeId { get; set; }

    public int? ComboListId { get; set; }

    public virtual ICollection<CrmCamposCriterio> CrmCamposCriterios { get; set; } = new List<CrmCamposCriterio>();

    public virtual ICollection<CrmClientesSegmento> CrmClientesSegmentos { get; set; } = new List<CrmClientesSegmento>();

    public virtual GsUsrType UsrType { get; set; }
}
