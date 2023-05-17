using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FormasPago
{
    public int IdformaPago { get; set; }

    public string Nombre { get; set; }

    public virtual ICollection<Certificacione> Certificaciones { get; set; } = new List<Certificacione>();

    public virtual ICollection<FacturacionPlanificacion> FacturacionPlanificacions { get; set; } = new List<FacturacionPlanificacion>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<FormasPagoApi> FormasPagoApis { get; set; } = new List<FormasPagoApi>();

    public virtual ICollection<LiquidacionesComercial> LiquidacionesComercials { get; set; } = new List<LiquidacionesComercial>();

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual ICollection<Vencimiento> Vencimientos { get; set; } = new List<Vencimiento>();
}
