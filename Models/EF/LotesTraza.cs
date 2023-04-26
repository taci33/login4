using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class LotesTraza
{
    public int IdloteTraza { get; set; }

    public int LoteIdorigen { get; set; }

    public int? LineaOsidorigen { get; set; }

    public int LoteIddestino { get; set; }

    public int? LineaOsiddestino { get; set; }

    public virtual OrdenesSeriadasDetalle LineaOsiddestinoNavigation { get; set; }

    public virtual OrdenesSeriadasDetalle LineaOsidorigenNavigation { get; set; }

    public virtual Lote LoteIddestinoNavigation { get; set; }

    public virtual Lote LoteIdorigenNavigation { get; set; }
}
