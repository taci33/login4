using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AeatM347
{
    public int Idmodelo { get; set; }

    public string Nif { get; set; }

    public string TipoSoporte { get; set; }

    public string Ejercicio { get; set; }

    public string RazonSocial { get; set; }

    public string ContactoTelefono { get; set; }

    public string Contacto { get; set; }

    public string NumeroPresentacion { get; set; }

    public bool DeclaracionComplementaria { get; set; }

    public bool DeclaracionSustitutiva { get; set; }

    public string NidentificativoDeclaracionAnterior { get; set; }

    public int? NumeroPersonasYentidades { get; set; }

    public decimal? ImporteTotalAnualOperaciones { get; set; }

    public int? NumeroInmuebles { get; set; }

    public decimal? ImporteTotalArrendamiento { get; set; }

    public string NifrepresentanteLegal { get; set; }
}
