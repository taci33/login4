﻿using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class VencimientosCompra
{
    public int Idvencimiento { get; set; }

    public int FacturaId { get; set; }

    public int? RemesaId { get; set; }

    public string NumeroVencimiento { get; set; }

    public DateTime FechaEmision { get; set; }

    public DateTime FechaCargo { get; set; }

    public string PersonaNif { get; set; }

    public int PersonaId { get; set; }

    public string PersonaNombre { get; set; }

    public string Cccadeudo { get; set; }

    public decimal Importe { get; set; }

    public int MedioId { get; set; }

    public bool Emitido { get; set; }

    public bool Pagado { get; set; }

    public bool Devuelto { get; set; }

    public bool DocumentoRecibido { get; set; }

    public bool Contabilizado { get; set; }

    public string CodigoConta { get; set; }

    public string Efectos { get; set; }

    public bool? Iban { get; set; }

    public int? CuentaEmpresaId { get; set; }

    public string Descripcion { get; set; }

    public virtual EmpresasCuentasBancaria CuentaEmpresa { get; set; }

    public virtual FacturasCompra Factura { get; set; }

    public virtual MediosPago Medio { get; set; }

    public virtual RemesasCompra Remesa { get; set; }
}
