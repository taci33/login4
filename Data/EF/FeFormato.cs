using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FeFormato
{
    public int Idformato { get; set; }

    public string Nombre { get; set; }

    public string Version { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();
}
