﻿using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VPrimeraDireccionProveedor
{
    public int? PersonaId { get; set; }

    public string CodigoConta { get; set; }

    public string Direccion { get; set; }
}
