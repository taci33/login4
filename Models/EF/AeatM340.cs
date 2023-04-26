using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AeatM340
{
    public int Idmodelo { get; set; }

    public string Nif { get; set; }

    public string TipoSoporte { get; set; }

    public int EjercicioId { get; set; }

    public string Periodo { get; set; }

    public string RazonSocial { get; set; }

    public string ContactoTelefono { get; set; }

    public string Contacto { get; set; }

    public string NumeroPresentacion { get; set; }

    public bool DeclaracionComplementaria { get; set; }

    public bool DeclaracionSustitutiva { get; set; }

    public string NidentificativoDeclaracionAnterior { get; set; }

    public int? Nregistros { get; set; }

    public decimal? ImporteTotalBi { get; set; }

    public decimal? ImporteTotalCuota { get; set; }

    public decimal? ImporteTotalOperaciones { get; set; }

    public string NifrepresentanteLegal { get; set; }

    public bool? Valida { get; set; }

    public virtual ICollection<AeatM340Detalle> AeatM340Detalles { get; set; } = new List<AeatM340Detalle>();
}
