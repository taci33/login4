using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanya
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public int? EjercicioId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public DateTime Falta { get; set; }

    public string Titulo { get; set; }

    public int TipoId { get; set; }

    public DateTime? Finicio { get; set; }

    public DateTime? Ffin { get; set; }

    public DateTime? FultEmision { get; set; }

    public DateTime? FsigEmision { get; set; }

    public string Codigo { get; set; }

    public bool? Generico { get; set; }

    public string Descripcion { get; set; }

    public string Objetivos { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public int EstadoId { get; set; }

    public virtual ICollection<CrmCampanyasCriterio> CrmCampanyasCriterios { get; set; } = new List<CrmCampanyasCriterio>();

    public virtual ICollection<CrmCampanyasDestinatario> CrmCampanyasDestinatarios { get; set; } = new List<CrmCampanyasDestinatario>();

    public virtual ICollection<CrmCampanyasDetalle> CrmCampanyasDetalles { get; set; } = new List<CrmCampanyasDetalle>();

    public virtual ICollection<CrmCampanyasDocumento> CrmCampanyasDocumentos { get; set; } = new List<CrmCampanyasDocumento>();

    public virtual ICollection<CrmCampanyasSeguimiento> CrmCampanyasSeguimientos { get; set; } = new List<CrmCampanyasSeguimiento>();

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual CrmCampanyasEstado Estado { get; set; }

    public virtual CrmCampanyasCdbo IdcdboNavigation { get; set; }

    public virtual CrmCampanyasTipo Tipo { get; set; }
}
