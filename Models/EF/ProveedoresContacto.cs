using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class ProveedoresContacto
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

    public virtual ICollection<AlbaranesCompra> AlbaranesCompras { get; set; } = new List<AlbaranesCompra>();

    public virtual ICollection<FacturasCompra> FacturasCompras { get; set; } = new List<FacturasCompra>();

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<PedidosCompra> PedidosCompras { get; set; } = new List<PedidosCompra>();

    public virtual Proveedore Persona { get; set; }

    public virtual ICollection<PresupuestosCompra> PresupuestosCompras { get; set; } = new List<PresupuestosCompra>();
}
