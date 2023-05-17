using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class EmpresasCuentasBancaria
{
    public int Idcuenta { get; set; }

    public int TitularId { get; set; }

    public string NumCta { get; set; }

    public string CtaConta { get; set; }

    public string CtaDescuento { get; set; }

    public string Nombre { get; set; }

    public decimal LimiteDescuento { get; set; }

    public string RutaFicherosN19 { get; set; }

    public string ExtensionFicherosN19 { get; set; }

    public string RutaFicherosN58 { get; set; }

    public string ExtensionFicherosN58 { get; set; }

    public string Alias { get; set; }

    public string SufijoPresentador { get; set; }

    public string Ibancodigo { get; set; }

    public string Ibancuenta { get; set; }

    public string Bic { get; set; }

    public bool? Activa { get; set; }

    public virtual ICollection<AlbaranesVentaAnticipo> AlbaranesVentaAnticipos { get; set; } = new List<AlbaranesVentaAnticipo>();

    public virtual ICollection<ConfiguracionEmpresaCtum> ConfiguracionEmpresaCtumM303Ccbdevolucions { get; set; } = new List<ConfiguracionEmpresaCtum>();

    public virtual ICollection<ConfiguracionEmpresaCtum> ConfiguracionEmpresaCtumM303Ccbingresos { get; set; } = new List<ConfiguracionEmpresaCtum>();

    public virtual ICollection<MediosPago> MediosPagos { get; set; } = new List<MediosPago>();

    public virtual ICollection<RemesasCompra> RemesasCompras { get; set; } = new List<RemesasCompra>();

    public virtual ICollection<RemesasVentum> RemesasVenta { get; set; } = new List<RemesasVentum>();

    public virtual ICollection<TesoreriaApunte> TesoreriaApuntes { get; set; } = new List<TesoreriaApunte>();

    public virtual ICollection<TesoreriaSaldosFecha> TesoreriaSaldosFechas { get; set; } = new List<TesoreriaSaldosFecha>();

    public virtual ConfiguracionEmpresa Titular { get; set; }

    public virtual ICollection<VencimientosCompra> VencimientosCompras { get; set; } = new List<VencimientosCompra>();

    public virtual ICollection<VencimientosVentum> VencimientosVenta { get; set; } = new List<VencimientosVentum>();
}
