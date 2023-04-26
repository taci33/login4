using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class SrvContrato
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public string Titulo { get; set; }

    public int Tipo { get; set; }

    public int PersonaId { get; set; }

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

    public decimal TotalCoste { get; set; }

    public string Observaciones { get; set; }

    public decimal Descuento { get; set; }

    public int? IvagrupoId { get; set; }

    public int PortesTipoId { get; set; }

    public decimal TotalPortes { get; set; }

    public decimal TotalFinanciacion { get; set; }

    public decimal TotalRetencion { get; set; }

    public int? EjercicioId { get; set; }

    public int? ContactoId { get; set; }

    public int? MedioId { get; set; }

    public string Cccadeudo { get; set; }

    public int? ComercialId { get; set; }

    public int? ComisionId { get; set; }

    public int? AgenciaId { get; set; }

    public double Peso { get; set; }

    public int? TarifaAgenciaId { get; set; }

    public int? TarifaId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public string Codigo { get; set; }

    public int CalculoPortesTipo { get; set; }

    public string ReferenciaPersona { get; set; }

    public DateTime? Frecepcion { get; set; }

    public bool? RevisionPrecios { get; set; }

    public int? CentroCosteId { get; set; }

    public string Version { get; set; }

    public decimal MargenBeneficio { get; set; }

    public int? ProyectoId { get; set; }

    public double Volumen { get; set; }

    public bool Renovable { get; set; }

    public double? Duracion { get; set; }

    public DateTime? FinicioContrato { get; set; }

    public DateTime? FfinContrato { get; set; }

    public DateTime? Frenovacion { get; set; }

    public bool Renovado { get; set; }

    public bool? FacturacionPorPlanificacion { get; set; }

    public virtual AgenciasTransporteTarifa AgenciasTransporteTarifa { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual Comerciale Comercial { get; set; }

    public virtual Comisione Comision { get; set; }

    public virtual ClientesContacto Contacto { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual SrvContratosEstado Estado { get; set; }

    public virtual SrvContratosCdbo IdcdboNavigation { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual MediosPago Medio { get; set; }

    public virtual Cliente Persona { get; set; }

    public virtual ClientesDireccione PersonaDireccionFactura { get; set; }

    public virtual Proyecto Proyecto { get; set; }

    public virtual Series Serie { get; set; }

    public virtual ICollection<SrvContratosDetalle> SrvContratosDetalles { get; set; } = new List<SrvContratosDetalle>();

    public virtual ICollection<SrvContratosPlanificacion> SrvContratosPlanificacions { get; set; } = new List<SrvContratosPlanificacion>();
}
