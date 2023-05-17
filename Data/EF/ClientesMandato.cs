using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesMandato
{
    public int Idmandato { get; set; }

    public int PersonaId { get; set; }

    public int TipoMandatoId { get; set; }

    public string ReferenciaMandato { get; set; }

    public DateTime Ffirma { get; set; }

    public bool Puntual { get; set; }

    public bool Finalizado { get; set; }

    public int? CuentaBancariaId { get; set; }

    public string Descripcion { get; set; }

    public virtual ClientesCuentasBancaria CuentaBancaria { get; set; }

    public virtual Cliente Persona { get; set; }
}
