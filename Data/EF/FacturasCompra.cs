using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class FacturasCompra
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public string Titulo { get; set; }

    public int Tipo { get; set; }

    public int PersonaId { get; set; }

    public string ReferenciaPersona { get; set; }

    public int SerieId { get; set; }

    public int? PersonaDireccionFacturaId { get; set; }

    public bool Entrega { get; set; }

    public int? PersonaDireccionEntregaId { get; set; }

    public int? FormaPagoId { get; set; }

    public int EstadoId { get; set; }

    public string Anno { get; set; }

    public int? Numero { get; set; }

    public DateTime Falta { get; set; }

    public DateTime? Fentrega { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal Total { get; set; }

    public string Observaciones { get; set; }

    public decimal Descuento { get; set; }

    public bool Contabilizada { get; set; }

    public int? MedioId { get; set; }

    public string Cccadeudo { get; set; }

    public int? IvagrupoId { get; set; }

    public int PortesTipoId { get; set; }

    public decimal TotalPortes { get; set; }

    public decimal TotalFinanciacion { get; set; }

    public decimal TotalRetencion { get; set; }

    public int? EjercicioId { get; set; }

    public int? ContactoId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public string Codigo { get; set; }

    public int? CentroCosteId { get; set; }

    public bool Facturae { get; set; }

    public DateTime? FeFenvio { get; set; }

    public int? ProyectoId { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public bool SiiExportado { get; set; }

    public string ClaveTipoFactura { get; set; }

    public string RectificativaClave { get; set; }

    public string ClaveTributariaOperacion { get; set; }

    public string DescripcionOperacion { get; set; }

    public string InmuebleSituacion { get; set; }

    public string InmuebleReferenciaCatastral { get; set; }

    public int? FacturaRectificadaId { get; set; }

    public string LiActividadTipo { get; set; }

    public string LiActividadGrupo { get; set; }

    public string LiConcepto { get; set; }

    public bool? OperacionCriterioCaja { get; set; }

    public virtual ICollection<Autofactura> Autofacturas { get; set; } = new List<Autofactura>();

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ProveedoresContacto Contacto { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual FacturasCompraEstado Estado { get; set; }

    public virtual ICollection<FacturasCompraDetalle> FacturasCompraDetalles { get; set; } = new List<FacturasCompraDetalle>();

    public virtual ICollection<FacturasCompraPie> FacturasCompraPies { get; set; } = new List<FacturasCompraPie>();

    public virtual FormasPago FormaPago { get; set; }

    public virtual FacturasCompraCdbo IdcdboNavigation { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual Proveedore Persona { get; set; }

    public virtual ProveedoresDireccione PersonaDireccionFactura { get; set; }

    public virtual PortesTipo PortesTipo { get; set; }

    public virtual Proyecto Proyecto { get; set; }

    public virtual Series Serie { get; set; }

    public virtual ICollection<VencimientosCompra> VencimientosCompras { get; set; } = new List<VencimientosCompra>();
}
