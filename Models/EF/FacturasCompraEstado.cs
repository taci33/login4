﻿using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FacturasCompraEstado
{
    public int Idestado { get; set; }

    public string Nombre { get; set; }

    public string FontColor { get; set; }

    public bool Traspaso { get; set; }

    public bool CantidadPendiente { get; set; }

    public bool? AllowModify { get; set; }

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();
}
