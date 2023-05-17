using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CtaAeatTerritorio
{
    public int Idterritorio { get; set; }

    public string Nombre { get; set; }

    public decimal M303PerCent { get; set; }

    public virtual ICollection<ConfiguracionEmpresaCtum> ConfiguracionEmpresaCta { get; set; } = new List<ConfiguracionEmpresaCtum>();
}
