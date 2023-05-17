using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class AeatM303
{
    public int Idmodelo { get; set; }

    public string Nif { get; set; }

    public string Tipo { get; set; }

    public string RazonSocial { get; set; }

    public bool InscritoRegistroDevMensual { get; set; }

    public int EjercicioId { get; set; }

    public string Periodo { get; set; }

    public decimal? Dev1Bi { get; set; }

    public decimal? Dev1Tipo { get; set; }

    public decimal? Dev1Cuota { get; set; }

    public decimal? Dev2Bi { get; set; }

    public decimal? Dev2Tipo { get; set; }

    public decimal? Dev2Cuota { get; set; }

    public decimal? Dev3Bi { get; set; }

    public decimal? Dev3Tipo { get; set; }

    public decimal? Dev3Cuota { get; set; }

    public decimal? DevRe1Bi { get; set; }

    public decimal? DevRe1Tipo { get; set; }

    public decimal? DevRe1Cuota { get; set; }

    public decimal? DevRe2Bi { get; set; }

    public decimal? DevRe2Tipo { get; set; }

    public decimal? DevRe2Cuota { get; set; }

    public decimal? DevRe3Bi { get; set; }

    public decimal? DevRe3Tipo { get; set; }

    public decimal? DevRe3Cuota { get; set; }

    public decimal? DevAdquisionesIntracomunitariasBi { get; set; }

    public decimal? DevAdquisionesIntracomunitariasCuota { get; set; }

    public decimal? DevTotalDevengado { get; set; }

    public decimal? DedOpInterioresCorrientesBi { get; set; }

    public decimal? DedOpInterioresCorrientesCuota { get; set; }

    public decimal? DedOpInterioresBienesInversionBi { get; set; }

    public decimal? DedOpInterioresBienesInversionCuota { get; set; }

    public decimal? DedImportacionCorrientesBi { get; set; }

    public decimal? DedImportacionCorrientesCuota { get; set; }

    public decimal? DedImportacionInversionBi { get; set; }

    public decimal? DedImportacionInversionCuota { get; set; }

    public decimal? DedAdquisicionIntracomunitariaCorrientesBi { get; set; }

    public decimal? DedAdquisicionIntracomunitariaCorrientesCuota { get; set; }

    public decimal? DedAdquisicionIntracomunitariaInversionBi { get; set; }

    public decimal? DedAdquisicionIntracomunitariaInversionCuota { get; set; }

    public decimal? DedCompensacionRegimenEspecialAgp { get; set; }

    public decimal? DedRegularizacionInversiones { get; set; }

    public decimal? DedRegularizacionAplicacionPerCentProrrata { get; set; }

    public decimal? DedTotalAdeducir { get; set; }

    public decimal? Diferencia { get; set; }

    public decimal? AdministracionEstadoPerCent { get; set; }

    public decimal? AdministracionEstado { get; set; }

    public decimal? CuotasAcompensar { get; set; }

    public decimal? EntregasIntracomunitarias { get; set; }

    public decimal? ExportacionesYoperacionsAsimiladas { get; set; }

    public decimal? OperacionesNoSujetas { get; set; }

    public decimal? TributacionConjunta { get; set; }

    public decimal? Resultado { get; set; }

    public decimal? Adeducir { get; set; }

    public decimal? ResultadoLiquidacion { get; set; }

    public decimal? ImporteAcompensar { get; set; }

    public bool SinActividad { get; set; }

    public decimal? DevolImporte { get; set; }

    public string IngFormaPago { get; set; }

    public decimal? IngImporte { get; set; }

    public bool Complementaria { get; set; }

    public string ComplementariaJustificante { get; set; }

    public string Localidad { get; set; }

    public DateTime? Fecha { get; set; }

    public bool IdTributaExclusivamenteRegimenSimplificado { get; set; }

    public bool IdAutoliquidacionConjunta { get; set; }

    public bool IdDeclaradoConcursoAcreedoresPresentePeriodo { get; set; }

    public DateTime? IdDeclaracionConcursoFechaAuto { get; set; }

    public int IdDeclaracionConcursoDictadoEnPeriodo { get; set; }

    public bool IdCriterioDeCaja { get; set; }

    public bool IdCriterioDeCajaDestinatario { get; set; }

    public bool IdAplicacionProrrataEspecial { get; set; }

    public bool IdAplicacionProrrataEspecialRevocacion { get; set; }

    public decimal? DevOtrasActividadesInversionSujetoPasivoBi { get; set; }

    public decimal? DevOtrasActividadesInversionSujetoPasivoCuota { get; set; }

    public decimal? DevModificacionBasesYcuotasBi { get; set; }

    public decimal? DevModificacionBasesYcuotasCuota { get; set; }

    public decimal? DevModificacionBasesYcuotasReBi { get; set; }

    public decimal? DevModificacionBasesYcuotasReCuota { get; set; }

    public decimal? DedModificacionBasesYcuotasBi { get; set; }

    public decimal? DedModificacionBasesYcuotasCuota { get; set; }

    public decimal? ReccEntregasBienesYserviciosBi { get; set; }

    public decimal? ReccEntregasBienesYserviciosCuota { get; set; }

    public decimal? ReccAdquisicionesBienesYserviciosBi { get; set; }

    public decimal? ReccAdquisicionesBienesYserviciosCuota { get; set; }

    public string DevolCcb { get; set; }

    public string IngCcb { get; set; }

    public int IdExisteVolumenOperacionesLiva { get; set; }

    public int SujPasivoTributaExcForalAduana { get; set; }

    public int VoluntarioLivasede { get; set; }

    public int IdExonerado390 { get; set; }

    public decimal? TributacionPorTerritorio { get; set; }

    public int IaExonClaveP { get; set; }

    public string IaExonIaeP { get; set; }

    public int IaExonClave1 { get; set; }

    public string IaExonIae1 { get; set; }

    public int IaExonClave2 { get; set; }

    public string IaExonIae2 { get; set; }

    public int IaExonClave3 { get; set; }

    public string IaExonIae3 { get; set; }

    public int IaExonClave4 { get; set; }

    public string IaExonIae4 { get; set; }

    public int IaExonClave5 { get; set; }

    public string IaExonIae5 { get; set; }

    public string IaExonMarcaTercerasPers { get; set; }

    public decimal? IaExonOperRg { get; set; }

    public decimal? IaExonOperRecc { get; set; }

    public decimal? IaExonOperEntIntrocomExentas { get; set; }

    public decimal? IaExonOperExentasSinDeduccion { get; set; }

    public decimal? IaExonOperNoSujetasLocal { get; set; }

    public decimal? IaExonOperEntregasBienesInsMont { get; set; }

    public decimal? IaExonOperRsimplificado { get; set; }

    public decimal? IaExonOperEntregasBienesNoHabituales { get; set; }

    public decimal? IaExonOperTotalVolumen { get; set; }

    public decimal? IaExonOperExportaciones { get; set; }

    public decimal? IaExonOperReAgricultura { get; set; }

    public decimal? IaExonOperSujetosRe { get; set; }

    public decimal? IaExonOperReBiensUsados { get; set; }

    public decimal? IaExonOperReAgenciasViajes { get; set; }

    public decimal? IaExonOperReEntregasBi { get; set; }

    public string NotasInternas { get; set; }

    public decimal? CuotasAcompensarAplicadasEnPeriodo { get; set; }

    public decimal? CuotasAcompensarAplicadasPeriodosPosteriores { get; set; }

    public decimal? OperacionesSujetasIsp { get; set; }

    public decimal? OssOperacionesNosujetasLocalizacion { get; set; }

    public decimal? OssOperacionesSujetas { get; set; }

    public virtual Ejercicio Ejercicio { get; set; }
}
