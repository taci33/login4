using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ClientesDireccione
{
    public int IdpersonaDireccion { get; set; }

    public long? Idcdbo { get; set; }

    public int PersonaId { get; set; }

    public int LocalidadId { get; set; }

    public int ProvinciaId { get; set; }

    public int PaisId { get; set; }

    public int? TipoDireccionId { get; set; }

    public string Nombre { get; set; }

    public string Direccion { get; set; }

    public string CodigoPostal { get; set; }

    public string Horario { get; set; }

    public bool Instalacion { get; set; }

    public int? TipoInstalacionId { get; set; }

    public string Observaciones { get; set; }

    public bool? Activa { get; set; }

    public virtual ICollection<AlbaranesVentum> AlbaranesVenta { get; set; } = new List<AlbaranesVentum>();

    public virtual ICollection<AlqAlquilere> AlqAlquileres { get; set; } = new List<AlqAlquilere>();

    public virtual ICollection<AlqPresupuesto> AlqPresupuestos { get; set; } = new List<AlqPresupuesto>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<ClientesContacto> ClientesContactoClientesDirecciones { get; set; } = new List<ClientesContacto>();

    public virtual ICollection<ClientesContacto> ClientesContactoPersonaDireccions { get; set; } = new List<ClientesContacto>();

    public virtual ICollection<ClientesTelefono> ClientesTelefonos { get; set; } = new List<ClientesTelefono>();

    public virtual ICollection<CrmAccione> CrmAcciones { get; set; } = new List<CrmAccione>();

    public virtual ICollection<DevolucionesVentum> DevolucionesVenta { get; set; } = new List<DevolucionesVentum>();

    public virtual ClientesDireccionesCdbo IdcdboNavigation { get; set; }

    public virtual Localidade Localidad { get; set; }

    public virtual Paise Pais { get; set; }

    public virtual ICollection<PedidosVentum> PedidosVenta { get; set; } = new List<PedidosVentum>();

    public virtual Cliente Persona { get; set; }

    public virtual ICollection<PresupuestosVentum> PresupuestosVenta { get; set; } = new List<PresupuestosVentum>();

    public virtual Provincia Provincia { get; set; }

    public virtual ICollection<SrvContrato> SrvContratos { get; set; } = new List<SrvContrato>();

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvPresupuestosVentum> SrvPresupuestosVenta { get; set; } = new List<SrvPresupuestosVentum>();

    public virtual ICollection<SrvPresupuestosVentaDetalle> SrvPresupuestosVentaDetalles { get; set; } = new List<SrvPresupuestosVentaDetalle>();

    public virtual ICollection<Tpvticket> TpvticketPersonaDireccionEntregas { get; set; } = new List<Tpvticket>();

    public virtual ICollection<Tpvticket> TpvticketPersonaDireccionFacturas { get; set; } = new List<Tpvticket>();
}
