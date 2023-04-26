using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FichajesParte
{
    public int Idcabecera { get; set; }

    public int? CabeceraId { get; set; }

    public int EstadoId { get; set; }

    public int FichajeDetalleId { get; set; }

    public int TipoId { get; set; }

    public int? OfId { get; set; }

    public int? OsId { get; set; }

    public double CantidadPf { get; set; }

    public double CantidadPfrechazada { get; set; }

    public int? OperacionId { get; set; }

    public int? MaquinaId { get; set; }

    public int? CentroId { get; set; }

    public double Cantidad { get; set; }

    public double TiempoPreparacion { get; set; }

    public double TiempoEfectivo { get; set; }

    public double Precio { get; set; }

    public double Coste { get; set; }

    public double CosteMedio { get; set; }

    public decimal TotalCoste { get; set; }

    public int? ParteId { get; set; }

    public long? Idcdbo { get; set; }

    public virtual FichajesParte Cabecera { get; set; }

    public virtual FichajesPartesEstado Estado { get; set; }

    public virtual FichajesDetalle FichajeDetalle { get; set; }

    public virtual FichajesTareasStandBy FichajesTareasStandBy { get; set; }

    public virtual ICollection<FichajesParte> InverseCabecera { get; set; } = new List<FichajesParte>();

    public virtual Maquina Maquina { get; set; }

    public virtual OrdenesFabricacion Of { get; set; }

    public virtual Operacione Operacion { get; set; }

    public virtual OrdenesSeriada Os { get; set; }

    public virtual Parte Parte { get; set; }
}
