using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmTarjetasFidelizacion
{
    public int PersonaId { get; set; }

    public string NumeroTarjeta { get; set; }

    public string Descripcion { get; set; }

    /// <summary>
    /// 1: Tarjeta Activa. 0: Tarjeta Inactiva
    /// </summary>
    public bool? Estado { get; set; }

    public virtual Cliente Persona { get; set; }
}
