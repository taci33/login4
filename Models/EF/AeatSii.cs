using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AeatSii
{
    public int Idpresentacion { get; set; }

    public string Nifdeclarante { get; set; }

    public string RazonSocial { get; set; }

    public string NifrepresentanteLegal { get; set; }

    public string ComunicacionTipo { get; set; }

    public string Ejercicio { get; set; }

    public string Periodo { get; set; }

    public string Autorizacion { get; set; }

    public DateTime Falta { get; set; }

    public int? TipoLibro { get; set; }

    public short? EstadoEnvio { get; set; }

    public byte[] TimestampPresentacion { get; set; }

    public string Csv { get; set; }

    public bool EditedCsvmanual { get; set; }
}
