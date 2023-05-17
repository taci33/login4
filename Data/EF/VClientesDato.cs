using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VClientesDato
{
    public int Idpersona { get; set; }

    public string ClienteDireccion { get; set; }

    public string ClienteCp { get; set; }

    public string ClienteLocalidad { get; set; }

    public string ClienteProvincia { get; set; }
}
