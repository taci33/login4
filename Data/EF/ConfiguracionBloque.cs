using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ConfiguracionBloque
{
    public int IdconfiguracionBloque { get; set; }

    public int ModeloId { get; set; }

    public string Stx { get; set; }

    public string Etb { get; set; }

    public string Dle { get; set; }

    public string Dle0 { get; set; }

    public string Dle1 { get; set; }

    public string Eot { get; set; }

    public string Nak { get; set; }

    public string Ak { get; set; }

    public string Enq { get; set; }

    public string Etx { get; set; }

    public virtual Modelo Modelo { get; set; }
}
