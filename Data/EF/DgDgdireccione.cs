using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DgDgdireccione
{
    public int DgdireccionId { get; set; }

    public int DocumentoGestionId { get; set; }

    public int CabeceraId { get; set; }

    public virtual DgDireccione Dgdireccion { get; set; }

    public virtual DocumentosGestion DocumentoGestion { get; set; }
}
