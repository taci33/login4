﻿using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class PedidosVentaDatosDinamico
{
    public int IddatoDinamicoRecordEntidad { get; set; }

    public int CabeceraId { get; set; }

    public int DatoDinamicoGsEntidadDefId { get; set; }

    public string Valor { get; set; }

    public virtual PedidosVentum Cabecera { get; set; }

    public virtual DatosDinamicosGsEntidadesDef DatoDinamicoGsEntidadDef { get; set; }
}
