using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Tpv
{
    public int Idtpv { get; set; }

    public int Numero { get; set; }

    public bool? Asignada { get; set; }

    public bool? Descatalogada { get; set; }

    public int? AlmacenIdDef { get; set; }

    public int? UbicacionIdDef { get; set; }

    public bool? CajonConnected { get; set; }

    public int? PuertoCajon { get; set; }

    public int? CodigoPuertoCajon { get; set; }

    public string CajonOpenString { get; set; }

    public int? PuertoImpresora { get; set; }

    public int? CodigoPuertoImpresora { get; set; }

    public bool? VisorConnected { get; set; }

    public int? PuertoVisor { get; set; }

    public int? CodigoPuertoVisor { get; set; }

    public int? LongMaxVisor { get; set; }

    public string SharedPrinterName { get; set; }

    public bool AllowMultiplesInstances { get; set; }

    public bool? PadConnected { get; set; }

    public bool? SignEmbed { get; set; }

    public int? SignLeft { get; set; }

    public int? SignRight { get; set; }

    public int? SignTop { get; set; }

    public int? SignBottom { get; set; }

    public string CertPath { get; set; }

    public string CertKeyPath { get; set; }

    public byte[] CertPass { get; set; }

    public virtual AlmacenesUbicacione AlmacenesUbicacione { get; set; }

    public virtual ICollection<Tpvcambio> Tpvcambios { get; set; } = new List<Tpvcambio>();

    public virtual ICollection<TpvmovimientosCaja> TpvmovimientosCajas { get; set; } = new List<TpvmovimientosCaja>();

    public virtual ICollection<TpvpagosPorCaja> TpvpagosPorCajas { get; set; } = new List<TpvpagosPorCaja>();

    public virtual ICollection<Tpvticket> Tpvtickets { get; set; } = new List<Tpvticket>();
}
