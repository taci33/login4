using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DgdUbicacione
{
    public int Iddgdu { get; set; }

    public int DocumentoGestionId { get; set; }

    public int CabeceraId { get; set; }

    public int LineaId { get; set; }

    public int AlmacenId { get; set; }

    public int UbicacionId { get; set; }

    public int ProductoId { get; set; }

    public int LoteId { get; set; }

    public int MedidaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public double Cantidad { get; set; }

    public double PrecioCoste { get; set; }

    public virtual Almacene Almacen { get; set; }

    public virtual DocumentosGestion DocumentoGestion { get; set; }

    public virtual Lote Lote { get; set; }

    public virtual Medida Medida { get; set; }

    public virtual Producto Producto { get; set; }

    public virtual AlmacenesUbicacione Ubicacion { get; set; }

    public virtual UnidadesMedidum UnidadMedida { get; set; }
}
