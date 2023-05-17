using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class BienesAmortizable
{
    public int Idcabecera { get; set; }

    public DateTime FechaAlta { get; set; }

    public int? Numero { get; set; }

    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public int EstadoId { get; set; }

    public int? FacturaCompraDetalleId { get; set; }

    public int? ProductoId { get; set; }

    public int? LoteId { get; set; }

    public DateTime FechaComienzoUso { get; set; }

    public int NaturalezaId { get; set; }

    public int TipoId { get; set; }

    public int? AlmacenId { get; set; }

    public int? UbicacionId { get; set; }

    public int? ResponsableId { get; set; }

    public decimal ValorBruto { get; set; }

    public decimal ValorResidual { get; set; }

    public decimal ValorAmortizable { get; set; }

    public decimal ValorPendienteAmortizar { get; set; }

    public int? CategoriaId { get; set; }

    public string CuentaAmortizacion { get; set; }

    public string CuentaDotacion { get; set; }

    public int Ndepreciaciones { get; set; }

    public int LongitudPeriodo { get; set; }

    public int MetodoDepreciacionId { get; set; }

    public bool? PrimeAmortProporcional { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? CausaBajaId { get; set; }

    public virtual Almacene Almacen { get; set; }

    public virtual BienesAmortizablesCategoria Categoria { get; set; }

    public virtual BienesAmortizablesBajaCausa CausaBaja { get; set; }

    public virtual BienesAmortizablesEstado Estado { get; set; }

    public virtual FacturasCompraDetalle FacturaCompraDetalle { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual BienesAmortizablesNaturaleza Naturaleza { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual Empleado Responsable { get; set; }

    public virtual BienesAmortizablesTipo Tipo { get; set; }

    public virtual AlmacenesUbicacione Ubicacion { get; set; }
}
