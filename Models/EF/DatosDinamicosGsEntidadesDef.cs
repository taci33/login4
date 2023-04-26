using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DatosDinamicosGsEntidadesDef
{
    public int IddatoDinamicoGsEntidadDef { get; set; }

    public int DatoDinamicoId { get; set; }

    public int EntidadId { get; set; }

    public int CategoryId { get; set; }

    public string DefaultValue { get; set; }

    public bool? Precargar { get; set; }

    public virtual ICollection<ClientesDatosDinamico> ClientesDatosDinamicos { get; set; } = new List<ClientesDatosDinamico>();

    public virtual DatosDinamico DatoDinamico { get; set; }

    public virtual DatosDinamicosGsEntidade Entidad { get; set; }

    public virtual ICollection<FamiliasDatosDinamico> FamiliasDatosDinamicos { get; set; } = new List<FamiliasDatosDinamico>();

    public virtual ICollection<OrdenesFabricacionDatosDinamico> OrdenesFabricacionDatosDinamicos { get; set; } = new List<OrdenesFabricacionDatosDinamico>();

    public virtual ICollection<OrdenesSeriadasDatosDinamico> OrdenesSeriadasDatosDinamicos { get; set; } = new List<OrdenesSeriadasDatosDinamico>();

    public virtual ICollection<PedidosVentaDatosDinamico> PedidosVentaDatosDinamicos { get; set; } = new List<PedidosVentaDatosDinamico>();

    public virtual ICollection<ProductosConjuntosDatosDinamico> ProductosConjuntosDatosDinamicos { get; set; } = new List<ProductosConjuntosDatosDinamico>();

    public virtual ICollection<ProductosDatosDinamico> ProductosDatosDinamicos { get; set; } = new List<ProductosDatosDinamico>();

    public virtual ICollection<ProyectosDatosDinamico> ProyectosDatosDinamicos { get; set; } = new List<ProyectosDatosDinamico>();
}
