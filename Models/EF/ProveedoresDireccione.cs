using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresDireccione
{
    public int IdpersonaDireccion { get; set; }

    public int PersonaId { get; set; }

    public int LocalidadId { get; set; }

    public int ProvinciaId { get; set; }

    public int PaisId { get; set; }

    public int TipoDireccionId { get; set; }

    public string Nombre { get; set; }

    public string Direccion { get; set; }

    public string CodigoPostal { get; set; }

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<Ope> OpePersonaDireccionEntregas { get; set; } = new List<Ope>();

    public virtual ICollection<Ope> OpePersonaDireccionFacturas { get; set; } = new List<Ope>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual Proveedore Persona { get; set; }

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();
}
