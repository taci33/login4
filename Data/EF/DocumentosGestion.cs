using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class DocumentosGestion
{
    public int IddocumentoGestion { get; set; }

    public int? DocumentoGestionId { get; set; }

    public int ModuloGestionId { get; set; }

    public int? FormularioId { get; set; }

    public int TipoEdicionCabecera { get; set; }

    public int DocumentoGestionDestinatarioId { get; set; }

    public string Nombre { get; set; }

    public string TableName { get; set; }

    public string WhereDestinatario { get; set; }

    public string WhereCabecera { get; set; }

    public int OrdenProceso { get; set; }

    public bool? AllowCopy { get; set; }

    public bool AllowPedidoAgencia { get; set; }

    public bool CalculoPortes { get; set; }

    /// <summary>
    /// 1: Recalculamos Precio al cambiar Cantidad; 0: No recalculamos
    /// </summary>
    public bool? RevisionPrecios { get; set; }

    public bool AllowInProyecto { get; set; }

    /// <summary>
    /// Referencia a la tabla GS_Entidades
    /// </summary>
    public int EntidadId { get; set; }

    public virtual ICollection<CrmClientesPuntosCabecera> CrmClientesPuntosCabeceras { get; set; } = new List<CrmClientesPuntosCabecera>();

    public virtual ICollection<CtaAsientosOrigene> CtaAsientosOrigenes { get; set; } = new List<CtaAsientosOrigene>();

    public virtual ICollection<DgdUbicacione> DgdUbicaciones { get; set; } = new List<DgdUbicacione>();

    public virtual DocumentosGestion DocumentoGestion { get; set; }

    public virtual DocumentosGestionDestinatario DocumentoGestionDestinatario { get; set; }

    public virtual ICollection<DocumentosGestionAsiento> DocumentosGestionAsientos { get; set; } = new List<DocumentosGestionAsiento>();

    public virtual ICollection<DocumentosGestionDetalleObservacione> DocumentosGestionDetalleObservaciones { get; set; } = new List<DocumentosGestionDetalleObservacione>();

    public virtual ICollection<DocumentosGestionDetalleUbicacione> DocumentosGestionDetalleUbicaciones { get; set; } = new List<DocumentosGestionDetalleUbicacione>();

    public virtual ICollection<DocumentosGestionMargenesClafe> DocumentosGestionMargenesClaves { get; set; } = new List<DocumentosGestionMargenesClafe>();

    public virtual ICollection<DocumentosGestionRegistroAlmacen> DocumentosGestionRegistroAlmacenDocumentoGestionDestinos { get; set; } = new List<DocumentosGestionRegistroAlmacen>();

    public virtual ICollection<DocumentosGestionRegistroAlmacen> DocumentosGestionRegistroAlmacenDocumentoGestionOrigens { get; set; } = new List<DocumentosGestionRegistroAlmacen>();

    public virtual ICollection<DocumentosGestionTiposLineaTiposLinea> DocumentosGestionTiposLineaTiposLineas { get; set; } = new List<DocumentosGestionTiposLineaTiposLinea>();

    public virtual ICollection<DocumentosGestionTiposLinea> DocumentosGestionTiposLineas { get; set; } = new List<DocumentosGestionTiposLinea>();

    public virtual ICollection<DocumentosGestionTraspaso> DocumentosGestionTraspasoDocumentoGestionDestinos { get; set; } = new List<DocumentosGestionTraspaso>();

    public virtual ICollection<DocumentosGestionTraspaso> DocumentosGestionTraspasoDocumentoGestionOrigens { get; set; } = new List<DocumentosGestionTraspaso>();

    public virtual ICollection<DocumentosGestionTraspasosSetup> DocumentosGestionTraspasosSetupDocumentoGestionDestinos { get; set; } = new List<DocumentosGestionTraspasosSetup>();

    public virtual ICollection<DocumentosGestionTraspasosSetup> DocumentosGestionTraspasosSetupDocumentoGestionOrigens { get; set; } = new List<DocumentosGestionTraspasosSetup>();

    public virtual GsEntidade Entidad { get; set; }

    public virtual ICollection<ExpedicionesDetalle> ExpedicionesDetalles { get; set; } = new List<ExpedicionesDetalle>();

    public virtual Formulario Formulario { get; set; }

    public virtual ICollection<DocumentosGestion> InverseDocumentoGestion { get; set; } = new List<DocumentosGestion>();

    public virtual ModulosGestion ModuloGestion { get; set; }

    public virtual ICollection<PropuestasCompra> PropuestasCompras { get; set; } = new List<PropuestasCompra>();
}
