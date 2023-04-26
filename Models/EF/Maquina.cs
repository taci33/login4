using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Maquina
{
    public int Idmaquina { get; set; }

    public double PrecioCoste { get; set; }

    public string Nombre { get; set; }

    public string Notas { get; set; }

    public string Descripcion { get; set; }

    public int? GrupoId { get; set; }

    public int? DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public int? PuestoId { get; set; }

    public int? EstadoId { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string Marca { get; set; }

    public string Modelo { get; set; }

    public string Nserie { get; set; }

    public string Fabricante { get; set; }

    public int? AnnoFabricacion { get; set; }

    public string Caracteristicas { get; set; }

    public string Mantenedor { get; set; }

    public string Potencia { get; set; }

    public string Voltaje { get; set; }

    public bool IsVehiculo { get; set; }

    public int? EmpleadoResponsableId { get; set; }

    public double TiempoPreparacion { get; set; }

    public virtual Departamento Departamento { get; set; }

    public virtual MaquinasEstado Estado { get; set; }

    public virtual ICollection<FichajesParte> FichajesPartes { get; set; } = new List<FichajesParte>();

    public virtual MaquinasGrupo Grupo { get; set; }

    public virtual ICollection<IsoMantenimiento> IsoMantenimientos { get; set; } = new List<IsoMantenimiento>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual Puesto Puesto { get; set; }

    public virtual Seccione Seccion { get; set; }

    public virtual ICollection<IsoActividade> Actividads { get; set; } = new List<IsoActividade>();

    public virtual ICollection<CentrosTrabajo> Centros { get; set; } = new List<CentrosTrabajo>();
}
