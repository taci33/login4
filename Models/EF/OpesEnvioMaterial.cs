using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class OpesEnvioMaterial
{
    public int? AlmacenOrigenId { get; set; }

    public int? UbicacionOrigenId { get; set; }

    public int ProductoId { get; set; }

    public int LoteId { get; set; }

    public double Cantidad { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public int? AlmacenDestinoId { get; set; }

    public int? UbicacionDestinoId { get; set; }

    public virtual Almacene AlmacenDestino { get; set; }

    public virtual Almacene AlmacenOrigen { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual AlmacenesUbicacione UbicacionDestino { get; set; }

    public virtual AlmacenesUbicacione UbicacionOrigen { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }
}
