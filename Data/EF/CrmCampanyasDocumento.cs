using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class CrmCampanyasDocumento
{
    public int Iddocumento { get; set; }

    public int CabeceraId { get; set; }

    public string Fichero { get; set; }

    public int? FormatoId { get; set; }

    public string Descripcion { get; set; }

    public int TipoId { get; set; }

    public virtual CrmCampanya Cabecera { get; set; }

    public virtual ICollection<CrmCampanyasDetalle> CrmCampanyasDetalles { get; set; } = new List<CrmCampanyasDetalle>();

    public virtual GdFormatosArchivo Formato { get; set; }

    public virtual CrmDocumentosTipo Tipo { get; set; }
}
