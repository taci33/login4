using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesContacto
{
    public int Id { get; set; }

    public int PersonaId { get; set; }

    public string Nombre { get; set; }

    public string Apellidos { get; set; }

    public string Telefono1 { get; set; }

    public string Telefono2 { get; set; }

    public string Email { get; set; }

    public string Cargo { get; set; }

    public string Departamento { get; set; }

    public string Notas { get; set; }

    public int? PersonaDireccionId { get; set; }

    public int ContactoTipoId { get; set; }

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual ClientesDireccione ClientesDireccione { get; set; }

    public virtual ClientesContactosTipo ContactoTipo { get; set; }

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();

    public virtual ICollection<CrmCampanyasDestinatario> CrmCampanyasDestinatarios { get; set; } = new List<CrmCampanyasDestinatario>();

    public virtual ICollection<CrmClientesSegmento> CrmClientesSegmentos { get; set; } = new List<CrmClientesSegmento>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ICollection<FacturasVentum> FacturasVenta { get; set; } = new List<FacturasVentum>();

    public virtual ICollection<LabBoletine> LabBoletines { get; set; } = new List<LabBoletine>();

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual Cliente Persona { get; set; }

    public virtual ClientesDireccione PersonaDireccion { get; set; }

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();
}
