using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Parte
{
    public int Idparte { get; set; }

    public int? OfId { get; set; }

    public int? OfDetalleId { get; set; }

    public int? OsId { get; set; }

    public int? OsDetalleId { get; set; }

    public int OfTipoId { get; set; }

    public int ParteTipoId { get; set; }

    public int ProductoId { get; set; }

    public int? MedidaId { get; set; }

    public int? UnidadMedidaId { get; set; }

    public double Cantidad { get; set; }

    public double TiempoPreparacion { get; set; }

    public double TiempoEfectivo { get; set; }

    public int? AlmacenId { get; set; }

    public int? UbicacionId { get; set; }

    public double Precio { get; set; }

    public double Coste { get; set; }

    public decimal TotalCoste { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public double CantidadPf { get; set; }

    public double CantidadPfrechazada { get; set; }

    public int? OperacionId { get; set; }

    public int? CualificacionId { get; set; }

    public int? CentroTipoId { get; set; }

    public bool CentroExterno { get; set; }

    public int? CentroId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? MaquinaId { get; set; }

    public DateTime? FechaImputacion { get; set; }

    public DateTime FechaParte { get; set; }

    public int? LoteId { get; set; }

    public string Observaciones { get; set; }

    public int? AceptadoPorEmpleadoId { get; set; }

    public long? Idcdbo { get; set; }

    public int? MedidaPfid { get; set; }

    public int? UnidadMedidaPfid { get; set; }

    public bool GestCorte { get; set; }

    public double UnidadesCorte { get; set; }

    public double CantidadX { get; set; }

    public double CantidadY { get; set; }

    public double CantidadZ { get; set; }

    public int? UnidadMedidaIdCorteX { get; set; }

    public int? UnidadMedidaIdCorteY { get; set; }

    public int? UnidadMedidaIdCorteZ { get; set; }

    public virtual Almacene Almacen { get; set; }

    public virtual CentrosTrabajo Centro { get; set; }

    public virtual CentrosTipo CentroTipo { get; set; }

    public virtual Cualificacione Cualificacion { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ICollection<FichajesParte> FichajesPartes { get; set; } = new List<FichajesParte>();

    public virtual PartesCdbo IdcdboNavigation { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Maquina Maquina { get; set; }

    public virtual OrdenesFabricacionDetalle OfDetalle { get; set; }

    public virtual OrdenesFabricacionTipo OfTipo { get; set; }

    public virtual Operacione Operacion { get; set; }

    public virtual OrdenesSeriadasDetalle OsDetalle { get; set; }

    public virtual PartesTipo ParteTipo { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual AlmacenesUbicacione Ubicacion { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteXNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteYNavigation { get; set; }

    public virtual UnidadesMedidum UnidadMedidaIdCorteZNavigation { get; set; }

    public virtual UnidadesMedidum UnidadesMedidum { get; set; }

    public virtual UnidadesMedidum UnidadesMedidumNavigation { get; set; }
}
