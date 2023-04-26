using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Expedicione
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public int EjercicioId { get; set; }

    public string Anno { get; set; }

    public int SerieId { get; set; }

    public int? Numero { get; set; }

    public string Codigo { get; set; }

    public DateTime Falta { get; set; }

    public bool Interna { get; set; }

    public int EstadoId { get; set; }

    public int? PersonaId { get; set; }

    public int? PersonaContactoId { get; set; }

    public int? TarifaAgenciaId { get; set; }

    public DateTime? Fsalida { get; set; }

    public string Titulo { get; set; }

    public string Observaciones { get; set; }

    public int? EmpresaId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpleadoResponsableId { get; set; }

    public string Transportista { get; set; }

    public string TransportistaTelefono { get; set; }

    public string VehiculoMatricula { get; set; }

    public string TrackingNumber { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Empleado EmpleadoResponsable { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual ICollection<ExpedicionesDetalle> ExpedicionesDetalles { get; set; } = new List<ExpedicionesDetalle>();

    public virtual ExpedicionesCdbo IdcdboNavigation { get; set; }

    public virtual Proveedore Persona { get; set; }

    public virtual Series Serie { get; set; }

    public virtual AgenciasTransporteTarifa TarifaAgencia { get; set; }
}
