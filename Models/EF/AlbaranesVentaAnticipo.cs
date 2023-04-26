using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AlbaranesVentaAnticipo
{
    public int Idanticipo { get; set; }

    public int CabeceraOrigenId { get; set; }

    public int? CabeceraDestinoId { get; set; }

    public int? VencimientoDestinoId { get; set; }

    public string NumeroAnticipo { get; set; }

    public DateTime FechaEmision { get; set; }

    public DateTime FechaCargo { get; set; }

    public string PersonaNif { get; set; }

    public int PersonaId { get; set; }

    public string PersonaNombre { get; set; }

    public string Cccadeudo { get; set; }

    public decimal Importe { get; set; }

    public int MedioId { get; set; }

    public bool? Pagado { get; set; }

    public bool Traspasado { get; set; }

    public string CodigoConta { get; set; }

    public string Efectos { get; set; }

    public bool? Iban { get; set; }

    public int? CuentaEmpresaId { get; set; }

    public string Descripcion { get; set; }

    public virtual FacturasVentum CabeceraDestino { get; set; }

    public virtual AlbaranesVentum CabeceraOrigen { get; set; }

    public virtual EmpresasCuentasBancaria CuentaEmpresa { get; set; }

    public virtual MediosPago Medio { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual VencimientosVentum VencimientoDestino { get; set; }
}
