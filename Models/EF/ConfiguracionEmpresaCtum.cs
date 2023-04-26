using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ConfiguracionEmpresaCtum
{
    public int Idctaempresa { get; set; }

    public int EmpresaId { get; set; }

    public int? TerritorioId { get; set; }

    public bool M303 { get; set; }

    public int? M303Periodicidad { get; set; }

    public bool M303InscritoRegistroDevMensual { get; set; }

    public int? M303CcbingresoId { get; set; }

    public int? M303CcbdevolucionId { get; set; }

    public string M303Path { get; set; }

    public string SiiNifrepresentanteLegal { get; set; }

    public string LiActividadTipoVDef { get; set; }

    public string LiActividadGrupoVDef { get; set; }

    public string LiActividadTipoCDef { get; set; }

    public string LiActividadGrupoCDef { get; set; }

    public string LiConceptoVDef { get; set; }

    public string LiConceptoCDef { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual EmpresasCuentasBancaria M303Ccbdevolucion { get; set; }

    public virtual EmpresasCuentasBancaria M303Ccbingreso { get; set; }

    public virtual CtaAeatTerritorio Territorio { get; set; }
}
