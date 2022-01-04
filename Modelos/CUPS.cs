using System;
using System.Collections.Generic;

namespace Modelos
{
    public partial class CUPS
{
    public long IdCups { get; set; }
    public string Entorno { get; set; }
    public bool? IsCups { get; set; }
    public string CodigoCUPS { get; set; }
    public long? IdFinca { get; set; }
    public long? IdCiudad { get; set; }
    public long? IdCallejero { get; set; }
    public int? Numero { get; set; }
    /*public long? IdCallejeroTipoNum { get; set; }
    public long? IdCallejeroTipoCalificador { get; set; }
    public long? IdCallejeroBloque { get; set; }
    public long? IdCallejeroPortal { get; set; }
    public long? IdCallejeroEscalera { get; set; }
    public long? IdCallejeroPiso { get; set; }
    public long? IdCallejeroPuerta { get; set; }*/
    public string Aclarador { get; set; }
    public string CodPostal { get; set; }
    public string TipoPS { get; set; }
    public string RefCatastral { get; set; }
    /*public long? IdDistribuidora { get; set; }
    public long? IdRedLineaMedia { get; set; }
    public long? IdRedCT { get; set; }
    public long? IdRedCTTransformador { get; set; }
    public long? IdRedCTCuadro { get; set; }
    public long? IdRedCTSalida { get; set; }
    public long? IdRedCTCircuito { get; set; }
    public long? IdRedCTAcometida { get; set; }
    public long? IdRedCTCaja { get; set; }
    public long? IdRedCTGeneral { get; set; }
    public decimal? X { get; set; }
    public decimal? Y { get; set; }
    public decimal? Z { get; set; }
    public decimal? PotAdscrita { get; set; }
    public decimal? PotPrevista { get; set; }
    public string TipoEdificio { get; set; }
    public DateTime? FechaMax { get; set; }
    public string DerechoExtension { get; set; }
    public string Situacion { get; set; }
    public DateTime? FechaOk { get; set; }
    public DateTime? FechaProxima { get; set; }
    public string Informe { get; set; }
    public bool? Contratacion { get; set; }
    public DateTime? FechaCont { get; set; }
    public string TextoCont { get; set; }
    public long? IdRuta { get; set; }
    public int? OrdenRuta { get; set; }
    public string Observaciones { get; set; }
    public string NumBoletin { get; set; }
    public DateTime? FechaIns { get; set; }
    public DateTime? FechaVigencia { get; set; }
    public string DirectorObra { get; set; }
    public string Titulacion { get; set; }
    public string Colegio { get; set; }
    public string NumColegiado { get; set; }
    public string Organismo { get; set; }
    public string Notificacion { get; set; }
    public string Referencia { get; set; }
    public string TitularCertificado { get; set; }
    public string CCI { get; set; }
    public string Categoria { get; set; }
    public string Modalidad { get; set; }
    public string ObsInstalacion { get; set; }
    public string ObsTerritorial { get; set; }
    public decimal? PotMax { get; set; }
    public long? IdCNAE { get; set; }
    public bool IsViviendaHabitual { get; set; }
    public decimal? PotenciaDisenoGas { get; set; }
    public DateTime? FechaIRIGas { get; set; }
    public decimal? CaudalGas { get; set; }
    public string OrganismoControlGas { get; set; }
    public DateTime? FechaUltimaInspeccionGas { get; set; }
    public DateTime? FechaVigenciaGas { get; set; }
    public string CodigoRedGas { get; set; }
    public string PCTDGas { get; set; }
    public decimal? PresionGas { get; set; }
    public bool? PTGas { get; set; }
    public bool? ReguladorGas { get; set; }
    public string ResultadoGas { get; set; }
    public DateTime? FechaInspeccionGas { get; set; }
    public bool? IsElectronico { get; set; }
    public long? IdTipoSuministro { get; set; }
    public long? IdZonaDistribucion { get; set; }
    public long? IdCliente { get; set; }
    public decimal? PotenciaNoInterrumpible { get; set; }
    public long? IdZonaCalidadServicio { get; set; }
    public int? TipoPuntoSuministro { get; set; }
    public int? ZonaClimatica { get; set; }
    public string OrigenPCS { get; set; }
    public string Zona { get; set; }
    public string DNI_Empleado { get; set; }
    public string Nombre_Empleado { get; set; }
    public DateTime? FechaCreacion { get; set; }
    public DateTime? FechaUltimaModificacion { get; set; }
    public bool? IsPlantaSatelite { get; set; }
    public bool? Cogenerador { get; set; }
    public bool? CicloCombinado { get; set; }*/
    /*public virtual ICollection<AgenteComision> AgenteComision { get; set; } = new HashSet<AgenteComision>();
    public virtual Callejero Callejero { get; set; }
    public virtual CallejeroBloque CallejeroBloque { get; set; }
    public virtual CallejeroEscalera CallejeroEscalera { get; set; }
    public virtual CallejeroPiso CallejeroPiso { get; set; }
    public virtual CallejeroPortal CallejeroPortal { get; set; }
    public virtual CallejeroPuerta CallejeroPuerta { get; set; }
    public virtual CallejeroTipoCalificador CallejeroTipoCalificador { get; set; }
    public virtual CallejeroTipoNumero CallejeroTipoNumero { get; set; }
    public virtual Ciudad Ciudad { get; set; }
    public virtual Cliente Cliente { get; set; }*/
    public virtual CNAE CNAE { get; set; }
    /*public virtual ICollection<Contrato> Contrato { get; set; } = new HashSet<Contrato>();
    public virtual ICollection<CUPSModificado> CUPSModificado { get; set; } = new HashSet<CUPSModificado>();
    public virtual Distribuidora Distribuidora { get; set; }
    public virtual RedCT RedCT { get; set; }
    public virtual RedCTAcometida RedCTAcometida { get; set; }
    public virtual RedCTCaja RedCTCaja { get; set; }
    public virtual RedCTCircuito RedCTCircuito { get; set; }
    public virtual RedCTCuadro RedCTCuadro { get; set; }
    public virtual RedCTGeneral RedCTGeneral { get; set; }
    public virtual RedCTSalida RedCTSalida { get; set; }
    public virtual RedCTTransformador RedCTTransformador { get; set; }
    public virtual RedLineaMedia RedLineaMedia { get; set; }
    public virtual Ruta Ruta { get; set; }
    public virtual TipoSuministro TipoSuministro { get; set; }*/
    /*public virtual ICollection<CUPSCapacidad> CUPSCapacidad { get; set; } = new HashSet<CUPSCapacidad>();
    public virtual ICollection<Fraude> Fraude { get; set; } = new HashSet<Fraude>();
    public virtual ICollection<ImportacionFicherosDistribuidoraGas> ImportacionFicherosDistribuidoraGas { get; set; } = new HashSet<ImportacionFicherosDistribuidoraGas>();
    public virtual ICollection<Solicitud> Solicitud { get; set; } = new HashSet<Solicitud>();
    public virtual ICollection<SolicitudCapacidad> SolicitudCapacidad { get; set; } = new HashSet<SolicitudCapacidad>();*/
}
}