using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class IsoIndicadore
{
    public int Idindicador { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int? ProcesoId { get; set; }

    public int? DepartamentoId { get; set; }

    public int? SeccionId { get; set; }

    public int? EmpleadoId { get; set; }

    public string Objetivos { get; set; }

    public DateTime? FechaPrevista { get; set; }

    public DateTime? FechaRealizacion { get; set; }

    public int? FrecuenciaId { get; set; }

    public double? ValorObjetivo { get; set; }

    public double? ValorObtenido { get; set; }

    public int? TendenciaId { get; set; }

    public bool ConformeObjetivo { get; set; }

    public string Debilidades { get; set; }

    public string Amenazas { get; set; }

    public string Fortalezas { get; set; }

    public string Oportunidades { get; set; }

    public virtual Departamento Departamento { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual IsoFrecuencia Frecuencia { get; set; }

    public virtual ICollection<IsoIndicadoresDetalle> IsoIndicadoresDetalles { get; set; } = new List<IsoIndicadoresDetalle>();

    public virtual IsoProceso Proceso { get; set; }

    public virtual Seccione Seccion { get; set; }

    public virtual IsoTendencia Tendencia { get; set; }
}
