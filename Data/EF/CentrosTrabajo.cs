using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CentrosTrabajo
{
    public int Idcentro { get; set; }

    public string Nombre { get; set; }

    public int CualificacionId { get; set; }

    public bool CentroExterno { get; set; }

    public int? ProveedorId { get; set; }

    public double PrecioCoste { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Capacidad { get; set; }

    public string Notas { get; set; }

    public decimal PhoraExtra { get; set; }

    public decimal PhoraExtraFestivo { get; set; }

    public decimal PrimaLaborable { get; set; }

    public decimal PrimaFestivo { get; set; }

    public decimal PrimaCompensacionFestivo { get; set; }

    public decimal PrimaMensual { get; set; }

    public virtual ICollection<Almacene> Almacenes { get; set; } = new List<Almacene>();

    public virtual Cualificacione Cualificacion { get; set; }

    public virtual ICollection<FasesCentro> FasesCentros { get; set; } = new List<FasesCentro>();

    public virtual ICollection<Ope> Opes { get; set; } = new List<Ope>();

    public virtual ICollection<OrdenesSeriadasDetalle> OrdenesSeriadasDetalles { get; set; } = new List<OrdenesSeriadasDetalle>();

    public virtual ICollection<Parte> Partes { get; set; } = new List<Parte>();

    public virtual Proveedore Proveedor { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<Maquina> Maquinas { get; set; } = new List<Maquina>();
}
