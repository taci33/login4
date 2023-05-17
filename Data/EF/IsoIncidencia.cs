using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoIncidencia
{
    public int Idcabecera { get; set; }

    public int? Numero { get; set; }

    public string Anno { get; set; }

    public int EstadoId { get; set; }

    public int TipoIncidenciaId { get; set; }

    public DateTime Falta { get; set; }

    public DateTime? FechaCierre { get; set; }

    public int TipoDestinatarioId { get; set; }

    public int DestinatarioId { get; set; }

    public string Descripcion { get; set; }

    public int? DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public int? EmpleadoId { get; set; }

    public string Causas { get; set; }

    public bool AperturaInforme { get; set; }

    public decimal TotalCoste { get; set; }

    public string Titulo { get; set; }

    public int? EjercicioId { get; set; }

    public string Resolucion { get; set; }

    public virtual Departamento Departamento { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual IsoIncidenciasEstado Estado { get; set; }

    public virtual ICollection<IsoIncidenciasDetalle> IsoIncidenciasDetalles { get; set; } = new List<IsoIncidenciasDetalle>();

    public virtual Seccione Seccion { get; set; }

    public virtual DocumentosGestionDestinatario TipoDestinatario { get; set; }

    public virtual IsoTiposIncidencia TipoIncidencia { get; set; }
}
