using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoMantenimiento
{
    public int Idcabecera { get; set; }

    public int MaquinaId { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int TipoId { get; set; }

    public int? IncidenciaId { get; set; }

    public DateTime? FechaRealizacion { get; set; }

    public int? FrecuenciaId { get; set; }

    public DateTime? FechaProxima { get; set; }

    public double Tiempo { get; set; }

    public decimal Importe { get; set; }

    public bool Externo { get; set; }

    public int? ProveedorId { get; set; }

    public int? EmpleadoId { get; set; }

    public bool Apto { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual IsoFrecuencia Frecuencia { get; set; }

    public virtual ICollection<IsoMantenimientosDetalle> IsoMantenimientosDetalles { get; set; } = new List<IsoMantenimientosDetalle>();

    public virtual Maquina Maquina { get; set; }

    public virtual Proveedore Proveedor { get; set; }

    public virtual IsoTiposMantenimiento Tipo { get; set; }
}
