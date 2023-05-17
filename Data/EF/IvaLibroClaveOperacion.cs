using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IvaLibroClaveOperacion
{
    public int IdclaveOperacion { get; set; }

    public string ClaveOperacion { get; set; }

    public string Descripcion { get; set; }

    public bool ClaveVoluntaria { get; set; }
}
