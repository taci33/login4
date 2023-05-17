using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Ope
{
    public int Idcabecera { get; set; }

    public long? Idcdbo { get; set; }

    public string Codigo { get; set; }

    public string Anno { get; set; }

    public int EjercicioId { get; set; }

    public int SerieId { get; set; }

    public int? Numero { get; set; }

    public int EstadoId { get; set; }

    public DateTime Falta { get; set; }

    public string Titulo { get; set; }

    public int PersonaId { get; set; }

    public int CentroId { get; set; }

    public DateTime? FechaInicioTeorica { get; set; }

    public DateTime? FechaFinTeorica { get; set; }

    public DateTime? FechaNecesidad { get; set; }

    public DateTime? FechaInicioReal { get; set; }

    public DateTime? FechaFinReal { get; set; }

    public string Observaciones { get; set; }

    public int? IvagrupoId { get; set; }

    public string ReferenciaPersona { get; set; }

    public int? PersonaDireccionFacturaId { get; set; }

    public bool Entrega { get; set; }

    public int? PersonaDireccionEntregaId { get; set; }

    public int? FormaPagoId { get; set; }

    public int? MedioId { get; set; }

    public int PortesTipoId { get; set; }

    public decimal Descuento { get; set; }

    public decimal BaseImponible { get; set; }

    public decimal TotalCosteTeorico { get; set; }

    public decimal TotalPortes { get; set; }

    public decimal TotalFinanciacion { get; set; }

    public decimal TotalRetencion { get; set; }

    public string Cccadeudo { get; set; }

    public int? ContactoId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? EmpresaId { get; set; }

    public int? AgenciaId { get; set; }

    public double Peso { get; set; }

    public int? TarifaAgenciaId { get; set; }

    public int NumeroBultos { get; set; }

    public string NumeroEnvio { get; set; }

    public int? CentroCosteId { get; set; }

    public int? ProyectoId { get; set; }

    public bool Impresa { get; set; }

    public virtual CentrosTrabajo Centro { get; set; }

    public virtual CtaCentroCoste CentroCoste { get; set; }

    public virtual ProveedoresContacto Contacto { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual ConfiguracionEmpresa Empresa { get; set; }

    public virtual OpesEstado Estado { get; set; }

    public virtual FormasPago FormaPago { get; set; }

    public virtual OpesCdbo IdcdboNavigation { get; set; }

    public virtual Ivagrupo Ivagrupo { get; set; }

    public virtual MediosPago Medio { get; set; }

    public virtual ICollection<OpesDetalle> OpesDetalles { get; set; } = new List<OpesDetalle>();

    public virtual Proveedore Persona { get; set; }

    public virtual ProveedoresDireccione PersonaDireccionEntrega { get; set; }

    public virtual ProveedoresDireccione PersonaDireccionFactura { get; set; }

    public virtual PortesTipo PortesTipo { get; set; }

    public virtual Proyecto Proyecto { get; set; }

    public virtual Series Serie { get; set; }
}
