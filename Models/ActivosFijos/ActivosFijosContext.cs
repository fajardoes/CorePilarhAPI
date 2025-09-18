using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class ActivosFijosContext : DbContext
{
    public ActivosFijosContext()
    {
    }

    public ActivosFijosContext(DbContextOptions<ActivosFijosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accesorio> Accesorios { get; set; }

    public virtual DbSet<AccesorioBaja> AccesorioBajas { get; set; }

    public virtual DbSet<Activo> Activos { get; set; }

    public virtual DbSet<ActivoActivacion> ActivoActivacions { get; set; }

    public virtual DbSet<ActivoActivodiferido> ActivoActivodiferidos { get; set; }

    public virtual DbSet<ActivoArea> ActivoAreas { get; set; }

    public virtual DbSet<ActivoBaja> ActivoBajas { get; set; }

    public virtual DbSet<ActivoDepreciadototal> ActivoDepreciadototals { get; set; }

    public virtual DbSet<Activoadjunto> Activoadjuntos { get; set; }

    public virtual DbSet<Activobajalote> Activobajalotes { get; set; }

    public virtual DbSet<Activobooleana> Activobooleanas { get; set; }

    public virtual DbSet<Activocaracteristicalistum> Activocaracteristicalista { get; set; }

    public virtual DbSet<ActivoeventualGaranthipotecar> ActivoeventualGaranthipotecars { get; set; }

    public virtual DbSet<ActivoeventualGarantprendarium> ActivoeventualGarantprendaria { get; set; }

    public virtual DbSet<Activofecha> Activofechas { get; set; }

    public virtual DbSet<Activoinformacionanterior> Activoinformacionanteriors { get; set; }

    public virtual DbSet<Activomejora> Activomejoras { get; set; }

    public virtual DbSet<Activonumerica> Activonumericas { get; set; }

    public virtual DbSet<Activooficinaprorrateo> Activooficinaprorrateos { get; set; }

    public virtual DbSet<Activooficinaprorrateoarea> Activooficinaprorrateoareas { get; set; }

    public virtual DbSet<Activotexto> Activotextos { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Avaluo> Avaluos { get; set; }

    public virtual DbSet<Calculo> Calculos { get; set; }

    public virtual DbSet<Calculooficina> Calculooficinas { get; set; }

    public virtual DbSet<Calculooficinacalculo> Calculooficinacalculos { get; set; }

    public virtual DbSet<Cargojuntadirectiva> Cargojuntadirectivas { get; set; }

    public virtual DbSet<CondicionCtacblevalorizacion> CondicionCtacblevalorizacions { get; set; }

    public virtual DbSet<CondicionCuentacontable> CondicionCuentacontables { get; set; }

    public virtual DbSet<Control> Controls { get; set; }

    public virtual DbSet<Controldetalle> Controldetalles { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Directivo> Directivos { get; set; }

    public virtual DbSet<Directivoparientevinculado> Directivoparientevinculados { get; set; }

    public virtual DbSet<DivisionestructuraactfijoCond> DivisionestructuraactfijoConds { get; set; }

    public virtual DbSet<EmpParmejecucionactivosfijo> EmpParmejecucionactivosfijos { get; set; }

    public virtual DbSet<Estadoactivo> Estadoactivos { get; set; }

    public virtual DbSet<Estadocivil> Estadocivils { get; set; }

    public virtual DbSet<Estadofisicoactivo> Estadofisicoactivos { get; set; }

    public virtual DbSet<Estadosolicregistroactadefunc> Estadosolicregistroactadefuncs { get; set; }

    public virtual DbSet<EstructactfijcondCuentasorden> EstructactfijcondCuentasordens { get; set; }

    public virtual DbSet<Etnium> Etnia { get; set; }

    public virtual DbSet<Huelladigitalpersona> Huelladigitalpersonas { get; set; }

    public virtual DbSet<Indicecorreccion> Indicecorreccions { get; set; }

    public virtual DbSet<Juntadirectiva> Juntadirectivas { get; set; }

    public virtual DbSet<Juntadirectivaintegrante> Juntadirectivaintegrantes { get; set; }

    public virtual DbSet<MotivoActivobaja> MotivoActivobajas { get; set; }

    public virtual DbSet<Motivobajdivestructuactfijcond> Motivobajdivestructuactfijconds { get; set; }

    public virtual DbSet<MovimientocontrolActivo> MovimientocontrolActivos { get; set; }

    public virtual DbSet<NivelCodigointerno> NivelCodigointernos { get; set; }

    public virtual DbSet<Oficina> Oficinas { get; set; }

    public virtual DbSet<OficinaComplemento> OficinaComplementos { get; set; }

    public virtual DbSet<OficinaComplementosri> OficinaComplementosris { get; set; }

    public virtual DbSet<OficinaFirmante> OficinaFirmantes { get; set; }

    public virtual DbSet<OficinaGeolocalizacion> OficinaGeolocalizacions { get; set; }

    public virtual DbSet<Oficinaarea> Oficinaareas { get; set; }

    public virtual DbSet<Oficinadepartamento> Oficinadepartamentos { get; set; }

    public virtual DbSet<Oficinapdum> Oficinapda { get; set; }

    public virtual DbSet<Oficinapuntoventum> Oficinapuntoventa { get; set; }

    public virtual DbSet<Oficinazona> Oficinazonas { get; set; }

    public virtual DbSet<Parentesco> Parentescos { get; set; }

    public virtual DbSet<Pdum> Pda { get; set; }

    public virtual DbSet<PerNatocupaciondireccion> PerNatocupaciondireccions { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<PersonaDireccionformateadum> PersonaDireccionformateada { get; set; }

    public virtual DbSet<PersonaEstado> PersonaEstados { get; set; }

    public virtual DbSet<PersonaFechaultimamodicacion> PersonaFechaultimamodicacions { get; set; }

    public virtual DbSet<PersonaGeolocation> PersonaGeolocations { get; set; }

    public virtual DbSet<PersonaLugarresidencium> PersonaLugarresidencia { get; set; }

    public virtual DbSet<PersonaNatural> PersonaNaturals { get; set; }

    public virtual DbSet<PersonaNaturalArrendatario> PersonaNaturalArrendatarios { get; set; }

    public virtual DbSet<PersonaNaturalConyugue> PersonaNaturalConyugues { get; set; }

    public virtual DbSet<PersonaNaturalFallecimiento> PersonaNaturalFallecimientos { get; set; }

    public virtual DbSet<PersonaNaturalLugarnacimiento> PersonaNaturalLugarnacimientos { get; set; }

    public virtual DbSet<PersonaNaturalPaisresidencium> PersonaNaturalPaisresidencia { get; set; }

    public virtual DbSet<PersonaNaturalPersonalizado> PersonaNaturalPersonalizados { get; set; }

    public virtual DbSet<PersonaNaturalbieninmueble> PersonaNaturalbieninmuebles { get; set; }

    public virtual DbSet<PersonaNaturalbieninmuebleDireccionformateadum> PersonaNaturalbieninmuebleDireccionformateada { get; set; }

    public virtual DbSet<PersonaNaturalconyuge> PersonaNaturalconyuges { get; set; }

    public virtual DbSet<PersonaNaturalfamiliar> PersonaNaturalfamiliars { get; set; }

    public virtual DbSet<PersonaNaturalobligacion> PersonaNaturalobligacions { get; set; }

    public virtual DbSet<PersonaNaturalocupacion> PersonaNaturalocupacions { get; set; }

    public virtual DbSet<PersonaNaturalocupacionGeolocation> PersonaNaturalocupacionGeolocations { get; set; }

    public virtual DbSet<PersonaNaturalocupacionorg> PersonaNaturalocupacionorgs { get; set; }

    public virtual DbSet<PersonaNaturalvehiculo> PersonaNaturalvehiculos { get; set; }

    public virtual DbSet<PersonaOrganizacion> PersonaOrganizacions { get; set; }

    public virtual DbSet<PersonaOrganizacionCompl> PersonaOrganizacionCompls { get; set; }

    public virtual DbSet<PersonaOrganizacionGrreunion> PersonaOrganizacionGrreunions { get; set; }

    public virtual DbSet<PersonaOrganizacionGruintgr> PersonaOrganizacionGruintgrs { get; set; }

    public virtual DbSet<PersonaOrganizacionGrupo> PersonaOrganizacionGrupos { get; set; }

    public virtual DbSet<PersonaOrganizacionReglegal> PersonaOrganizacionReglegals { get; set; }

    public virtual DbSet<PersonaOrganizacionaccionistum> PersonaOrganizacionaccionista { get; set; }

    public virtual DbSet<PersonaOrganizacioncontacto> PersonaOrganizacioncontactos { get; set; }

    public virtual DbSet<PersonaOrganizacionocupacion> PersonaOrganizacionocupacions { get; set; }

    public virtual DbSet<PersonaResponsable> PersonaResponsables { get; set; }

    public virtual DbSet<Personabooleana> Personabooleanas { get; set; }

    public virtual DbSet<Personacorreo> Personacorreos { get; set; }

    public virtual DbSet<Personadocumentoadicionalr> Personadocumentoadicionalrs { get; set; }

    public virtual DbSet<Personafamiliar> Personafamiliars { get; set; }

    public virtual DbSet<Personafecha> Personafechas { get; set; }

    public virtual DbSet<Personainfoburo> Personainfoburos { get; set; }

    public virtual DbSet<Personalistum> Personalista { get; set; }

    public virtual DbSet<Personanumerica> Personanumericas { get; set; }

    public virtual DbSet<Personaproveedor> Personaproveedors { get; set; }

    public virtual DbSet<Personatexto> Personatextos { get; set; }

    public virtual DbSet<Profesion> Profesions { get; set; }

    public virtual DbSet<PuntodeventaDepartamento> PuntodeventaDepartamentos { get; set; }

    public virtual DbSet<Rangoedad> Rangoedads { get; set; }

    public virtual DbSet<Referenciabancarium> Referenciabancaria { get; set; }

    public virtual DbSet<Referenciacomercial> Referenciacomercials { get; set; }

    public virtual DbSet<Referencium> Referencia { get; set; }

    public virtual DbSet<Representante> Representantes { get; set; }

    public virtual DbSet<Representantehistorico> Representantehistoricos { get; set; }

    public virtual DbSet<Representantehistoricodetalle> Representantehistoricodetalles { get; set; }

    public virtual DbSet<Solicitudactivobaja> Solicitudactivobajas { get; set; }

    public virtual DbSet<SolicitudactivobajaCompcausal> SolicitudactivobajaCompcausals { get; set; }

    public virtual DbSet<Solicitudactivobajacambioest> Solicitudactivobajacambioests { get; set; }

    public virtual DbSet<Solicitudactivobajalote> Solicitudactivobajalotes { get; set; }

    public virtual DbSet<Solicitudregistroactadefuncion> Solicitudregistroactadefuncions { get; set; }

    public virtual DbSet<Telefonopersona> Telefonopersonas { get; set; }

    public virtual DbSet<Telefonopersonahistorico> Telefonopersonahistoricos { get; set; }

    public virtual DbSet<Telpersonahistoricodetalle> Telpersonahistoricodetalles { get; set; }

    public virtual DbSet<Tipoarea> Tipoareas { get; set; }

    public virtual DbSet<Tipocuentareferenciabancarium> Tipocuentareferenciabancaria { get; set; }

    public virtual DbSet<Tipodocumentoadicional> Tipodocumentoadicionals { get; set; }

    public virtual DbSet<TipodocumentoadicionalAutomatica> TipodocumentoadicionalAutomaticas { get; set; }

    public virtual DbSet<TipodocumentoadicionalFormato> TipodocumentoadicionalFormatos { get; set; }

    public virtual DbSet<TipodocumentoadicionalMetodo> TipodocumentoadicionalMetodos { get; set; }

    public virtual DbSet<Tipoeducacion> Tipoeducacions { get; set; }

    public virtual DbSet<Tipogrupo> Tipogrupos { get; set; }

    public virtual DbSet<Tipoidentificacion> Tipoidentificacions { get; set; }

    public virtual DbSet<TipoidentificacionAutomatica> TipoidentificacionAutomaticas { get; set; }

    public virtual DbSet<TipoidentificacionCambio> TipoidentificacionCambios { get; set; }

    public virtual DbSet<TipoidentificacionCodcrerep> TipoidentificacionCodcrereps { get; set; }

    public virtual DbSet<TipoidentificacionFormato> TipoidentificacionFormatos { get; set; }

    public virtual DbSet<TipoidentificacionMetodo> TipoidentificacionMetodos { get; set; }

    public virtual DbSet<TipoidentificacionRdep> TipoidentificacionRdeps { get; set; }

    public virtual DbSet<Tipoidentificacionpai> Tipoidentificacionpais { get; set; }

    public virtual DbSet<Tipoidentificacionrangoedad> Tipoidentificacionrangoedads { get; set; }

    public virtual DbSet<Tipolocal> Tipolocals { get; set; }

    public virtual DbSet<Tipoocupacion> Tipoocupacions { get; set; }

    public virtual DbSet<Tiporepresentante> Tiporepresentantes { get; set; }

    public virtual DbSet<Tiporeuniongrupo> Tiporeuniongrupos { get; set; }

    public virtual DbSet<Tipoviviendum> Tipovivienda { get; set; }

    public virtual DbSet<Traslado> Traslados { get; set; }

    public virtual DbSet<Trasladodetalle> Trasladodetalles { get; set; }

    public virtual DbSet<Zona> Zonas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accesorio>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("ACCESORIO_PK")
                .HasFillFactor(80);

            entity.ToTable("ACCESORIO", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => e.Secuencialactivo, "ACCESORIO_I01").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(400)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .HasColumnName("MODELO");
            entity.Property(e => e.Numeroserie)
                .HasMaxLength(100)
                .HasColumnName("NUMEROSERIE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Accesorios)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ACCESORIO_R01");
        });

        modelBuilder.Entity<AccesorioBaja>(entity =>
        {
            entity.HasKey(e => e.Secuencialaccesorio)
                .HasName("ACCESORIO_BAJA_PK")
                .HasFillFactor(80);

            entity.ToTable("ACCESORIO_BAJA", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialaccesorio)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALACCESORIO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Fechabaja)
                .HasColumnType("datetime")
                .HasColumnName("FECHABAJA");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Motivo)
                .HasMaxLength(300)
                .HasColumnName("MOTIVO");

            entity.HasOne(d => d.SecuencialaccesorioNavigation).WithOne(p => p.AccesorioBaja)
                .HasForeignKey<AccesorioBaja>(d => d.Secuencialaccesorio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ACCESORIO_BAJA_R01");
        });

        modelBuilder.Entity<Activo>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("ACTIVO_PK")
                .HasFillFactor(80);

            entity.ToTable("ACTIVO", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialdivestructuraactfijo, e.Numerosecuencial }, "IX_ACTIVO").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocompuesto)
                .HasMaxLength(100)
                .HasColumnName("CODIGOCOMPUESTO");
            entity.Property(e => e.Codigoestadoactivo)
                .HasMaxLength(20)
                .HasColumnName("CODIGOESTADOACTIVO");
            entity.Property(e => e.Codigoestadofisicoactivo)
                .HasMaxLength(20)
                .HasColumnName("CODIGOESTADOFISICOACTIVO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Esactivodiferido).HasColumnName("ESACTIVODIFERIDO");
            entity.Property(e => e.Eseventual).HasColumnName("ESEVENTUAL");
            entity.Property(e => e.Fechaadquisicion)
                .HasColumnType("datetime")
                .HasColumnName("FECHAADQUISICION");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Numerosecuencial).HasColumnName("NUMEROSECUENCIAL");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivestructuraactfijo).HasColumnName("SECUENCIALDIVESTRUCTURAACTFIJO");
            entity.Property(e => e.Secuencialmoneda).HasColumnName("SECUENCIALMONEDA");
            entity.Property(e => e.Secuencialoficinadepartamento).HasColumnName("SECUENCIALOFICINADEPARTAMENTO");
            entity.Property(e => e.Secuencialpersonaresponsable).HasColumnName("SECUENCIALPERSONARESPONSABLE");

            entity.HasOne(d => d.CodigoestadoactivoNavigation).WithMany(p => p.Activos)
                .HasForeignKey(d => d.Codigoestadoactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ACTIVO_R04");

            entity.HasOne(d => d.CodigoestadofisicoactivoNavigation).WithMany(p => p.Activos)
                .HasForeignKey(d => d.Codigoestadofisicoactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_ESTADOFISICOACTIVO");

            entity.HasOne(d => d.SecuencialoficinadepartamentoNavigation).WithMany(p => p.Activos)
                .HasForeignKey(d => d.Secuencialoficinadepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_OFICINADEPARTAMENTO");

            entity.HasOne(d => d.SecuencialpersonaresponsableNavigation).WithMany(p => p.Activos)
                .HasForeignKey(d => d.Secuencialpersonaresponsable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_PERSONA_RESPONSABLE");
        });

        modelBuilder.Entity<ActivoActivacion>(entity =>
        {
            entity.HasKey(e => e.Secuencialactivo).HasFillFactor(80);

            entity.ToTable("ACTIVO_ACTIVACION", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialactivo)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Secuencialpersonarespini).HasColumnName("SECUENCIALPERSONARESPINI");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithOne(p => p.ActivoActivacion)
                .HasForeignKey<ActivoActivacion>(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_ACTIVACION_ACTIVO");
        });

        modelBuilder.Entity<ActivoActivodiferido>(entity =>
        {
            entity.HasKey(e => e.Secuencialactivo)
                .HasName("PK_ACTIVO_PLAZOVENCIMIENTO")
                .HasFillFactor(80);

            entity.ToTable("ACTIVO_ACTIVODIFERIDO", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialactivo)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Plazo).HasColumnName("PLAZO");
            entity.Property(e => e.Valorasegurado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORASEGURADO");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithOne(p => p.ActivoActivodiferido)
                .HasForeignKey<ActivoActivodiferido>(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_PLAZOVENCIMIENTO_ACTIVO");
        });

        modelBuilder.Entity<ActivoArea>(entity =>
        {
            entity.HasKey(e => e.Secuencialactivo).HasFillFactor(80);

            entity.ToTable("ACTIVO_AREA", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialactivo)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialarea).HasColumnName("SECUENCIALAREA");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithOne(p => p.ActivoArea)
                .HasForeignKey<ActivoArea>(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_AREA_ACTIVO");

            entity.HasOne(d => d.SecuencialareaNavigation).WithMany(p => p.ActivoAreas)
                .HasForeignKey(d => d.Secuencialarea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_AREA_AREA");
        });

        modelBuilder.Entity<ActivoBaja>(entity =>
        {
            entity.HasKey(e => e.Secuencialactivo)
                .HasName("ACTIVO_BAJA_PK")
                .HasFillFactor(80);

            entity.ToTable("ACTIVO_BAJA", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialactivo)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Detalleautorizacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DETALLEAUTORIZACION");
            entity.Property(e => e.Fechabaja)
                .HasColumnType("datetime")
                .HasColumnName("FECHABAJA");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Motivo)
                .HasMaxLength(100)
                .HasColumnName("MOTIVO");
            entity.Property(e => e.Secuencialmotivobaja).HasColumnName("SECUENCIALMOTIVOBAJA");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithOne(p => p.ActivoBaja)
                .HasForeignKey<ActivoBaja>(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ACTIVO_BAJA_R01");

            entity.HasOne(d => d.SecuencialmotivobajaNavigation).WithMany(p => p.ActivoBajas)
                .HasForeignKey(d => d.Secuencialmotivobaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_BAJA_MOTIVO_ACTIVOBAJA");
        });

        modelBuilder.Entity<ActivoDepreciadototal>(entity =>
        {
            entity.HasKey(e => e.Secuencialactivo).HasFillFactor(80);

            entity.ToTable("ACTIVO_DEPRECIADOTOTAL", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialactivo)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(25)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithOne(p => p.ActivoDepreciadototal)
                .HasForeignKey<ActivoDepreciadototal>(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVO_DEPRECIADOTOTAL_ACTIVO");
        });

        modelBuilder.Entity<Activoadjunto>(entity =>
        {
            entity.HasKey(e => e.Secuencial);

            entity.ToTable("ACTIVOADJUNTO", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Contenttype)
                .HasMaxLength(200)
                .HasColumnName("CONTENTTYPE");
            entity.Property(e => e.Fecharegistro)
                .HasColumnType("datetime")
                .HasColumnName("FECHAREGISTRO");
            entity.Property(e => e.Filedata).HasColumnName("FILEDATA");
            entity.Property(e => e.Filename)
                .HasMaxLength(500)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Activoadjuntos)
                .HasForeignKey(d => d.Secuencialactivo)
                .HasConstraintName("FK_ACTIVOADJUNTO_ACTIVO");
        });

        modelBuilder.Entity<Activobajalote>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVOBAJALOTE", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuarioingreso)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIOINGRESO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialmotivobaja).HasColumnName("SECUENCIALMOTIVOBAJA");

            entity.HasOne(d => d.SecuencialmotivobajaNavigation).WithMany(p => p.Activobajalotes)
                .HasForeignKey(d => d.Secuencialmotivobaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOBAJALOTE_MOTIVOBAJA");
        });

        modelBuilder.Entity<Activobooleana>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVOBOOLEANA", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivo, e.Codigocaracteristica }, "IX_ACTIVOBOOLEANA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Valor).HasColumnName("VALOR");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Activobooleanas)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOBOOLEANA_DIVISION");
        });

        modelBuilder.Entity<Activocaracteristicalistum>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK_DIVISIONLISTA")
                .HasFillFactor(80);

            entity.ToTable("ACTIVOCARACTERISTICALISTA", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivo, e.Secuencialcaracteristicalista }, "IX_ACTIVOCARACTERISTICALISTA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Secuencialcaracteristicalista).HasColumnName("SECUENCIALCARACTERISTICALISTA");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Activocaracteristicalista)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONLISTA_DIVISION");
        });

        modelBuilder.Entity<ActivoeventualGaranthipotecar>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVOEVENTUAL_GARANTHIPOTECAR", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Fechamaquina).HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema).HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Secuencialgarantiahipotecaria).HasColumnName("SECUENCIALGARANTIAHIPOTECARIA");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.ActivoeventualGaranthipotecars)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOEVENTUAL_GARANTHIPOTECAR_ACTIVO");
        });

        modelBuilder.Entity<ActivoeventualGarantprendarium>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVOEVENTUAL_GARANTPRENDARIA", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Fechamaquina).HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema).HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Secuencialgarantiaprendaria).HasColumnName("SECUENCIALGARANTIAPRENDARIA");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.ActivoeventualGarantprendaria)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOEVENTUAL_GARANTPRENDARIA_ACTIVO");
        });

        modelBuilder.Entity<Activofecha>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVOFECHA", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivo, e.Codigocaracteristica }, "IX_ACTIVOFECHA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Valor)
                .HasColumnType("datetime")
                .HasColumnName("VALOR");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Activofechas)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOFECHA_DIVISION");
        });

        modelBuilder.Entity<Activoinformacionanterior>(entity =>
        {
            entity.HasKey(e => e.Secuencialactivo).HasFillFactor(80);

            entity.ToTable("ACTIVOINFORMACIONANTERIOR", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialactivo)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Codigoanterior)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGOANTERIOR");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithOne(p => p.Activoinformacionanterior)
                .HasForeignKey<Activoinformacionanterior>(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOINFORMACIONANTERIOR_ACTIVO");
        });

        modelBuilder.Entity<Activomejora>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVOMEJORA", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Observacion)
                .HasMaxLength(500)
                .HasColumnName("OBSERVACION");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALOR");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Activomejoras)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOMEJORA_ACTIVO");
        });

        modelBuilder.Entity<Activonumerica>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVONUMERICA", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivo, e.Codigocaracteristica }, "IX_ACTIVONUMERICA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Valordecimal).HasColumnName("VALORDECIMAL");
            entity.Property(e => e.Valorentero).HasColumnName("VALORENTERO");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Activonumericas)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVONUMERICA_DIVISION");
        });

        modelBuilder.Entity<Activooficinaprorrateo>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK_ACTIVOOFICINAPORCENPRORRATEO")
                .HasFillFactor(80);

            entity.ToTable("ACTIVOOFICINAPRORRATEO", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivo, e.Secuencialoficina }, "IX_ACTIVOOFICINAPRORRATEO")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Activooficinaprorrateos)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOOFICINAPORCENPRORRATEO_ACTIVO");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithMany(p => p.Activooficinaprorrateos)
                .HasForeignKey(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOOFICINAPRORRATEO_OFICINA");
        });

        modelBuilder.Entity<Activooficinaprorrateoarea>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVOOFICINAPRORRATEOAREA", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivooficinaporrateo, e.Secuencialarea }, "IX_ACTIVOOFICINAPRORRATEOAREA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.Secuencialactivooficinaporrateo).HasColumnName("SECUENCIALACTIVOOFICINAPORRATEO");
            entity.Property(e => e.Secuencialarea).HasColumnName("SECUENCIALAREA");

            entity.HasOne(d => d.SecuencialactivooficinaporrateoNavigation).WithMany(p => p.Activooficinaprorrateoareas)
                .HasForeignKey(d => d.Secuencialactivooficinaporrateo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOOFICINAPRORRATEOAREA_ACTIVOOFICINAPRORRATEO");
        });

        modelBuilder.Entity<Activotexto>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ACTIVOTEXTO", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivo, e.Codigocaracteristica }, "IX_ACTIVOTEXTO")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Valor)
                .HasMaxLength(500)
                .HasColumnName("VALOR");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Activotextos)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVOTEXTO_DIVISION");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("AREA_PK")
                .HasFillFactor(80);

            entity.ToTable("AREA", "FBS_ORGANIZACIONES");

            entity.HasIndex(e => e.Secuencialempresa, "IX_AREA").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigo)
                .HasMaxLength(40)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Codigotipoarea)
                .HasMaxLength(20)
                .HasColumnName("CODIGOTIPOAREA");
            entity.Property(e => e.Esoperativa).HasColumnName("ESOPERATIVA");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Pordefecto).HasColumnName("PORDEFECTO");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");

            entity.HasOne(d => d.CodigotipoareaNavigation).WithMany(p => p.Areas)
                .HasForeignKey(d => d.Codigotipoarea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AREA_TIPOAREA");
        });

        modelBuilder.Entity<Avaluo>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("AVALUO_PK")
                .HasFillFactor(80);

            entity.ToTable("AVALUO", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivo, e.Fechaavaluo }, "AVALUO_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Concepto)
                .HasMaxLength(300)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.Depreciacionacumuladaactual)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DEPRECIACIONACUMULADAACTUAL");
            entity.Property(e => e.Fechaavaluo)
                .HasColumnType("datetime")
                .HasColumnName("FECHAAVALUO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Porctjdepreciacionacumulada)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PORCTJDEPRECIACIONACUMULADA");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Valoractual)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORACTUAL");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Avaluos)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AVALUO_R01");
        });

        modelBuilder.Entity<Calculo>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("CALCULO_PK")
                .HasFillFactor(80);

            entity.ToTable("CALCULO", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialactivo, e.Fechacalculo }, "CALCULO_I01")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.Secuencial, e.Secuencialactivo }, "IX_CALCULO").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Depreciacionacumulada)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DEPRECIACIONACUMULADA");
            entity.Property(e => e.Depreciacionperiodo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DEPRECIACIONPERIODO");
            entity.Property(e => e.Estadepreciadototal).HasColumnName("ESTADEPRECIADOTOTAL");
            entity.Property(e => e.Fechacalculo)
                .HasColumnType("datetime")
                .HasColumnName("FECHACALCULO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Incremento)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INCREMENTO");
            entity.Property(e => e.Indicecorreccion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INDICECORRECCION");
            entity.Property(e => e.Porcentajedepreciacionperiodo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PORCENTAJEDEPRECIACIONPERIODO");
            entity.Property(e => e.Porctjdepreciacionacumulada)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PORCTJDEPRECIACIONACUMULADA");
            entity.Property(e => e.Saldolibros)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALDOLIBROS");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Valoranterior)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORANTERIOR");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Calculos)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CALCULO_R01");
        });

        modelBuilder.Entity<Calculooficina>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("CALCULOOFICINA_PK")
                .HasFillFactor(80);

            entity.ToTable("CALCULOOFICINA", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialoficina, e.Fechacalculo, e.Esdiferido }, "CALCULOOFICINA_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Secuencialoficina, "IX_CALCULOOFICINA").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Esdiferido).HasColumnName("ESDIFERIDO");
            entity.Property(e => e.Eseventual).HasColumnName("ESEVENTUAL");
            entity.Property(e => e.Fechacalculo)
                .HasColumnType("datetime")
                .HasColumnName("FECHACALCULO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithMany(p => p.Calculooficinas)
                .HasForeignKey(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CALCULOOFICINA_OFICINA");
        });

        modelBuilder.Entity<Calculooficinacalculo>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("CALCULOOFICINACALCULO", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialcalculooficina, e.Secuencialcalculo }, "IX_CALCULOOFICINACALCULO")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Secuencialcalculo).HasColumnName("SECUENCIALCALCULO");
            entity.Property(e => e.Secuencialcalculooficina).HasColumnName("SECUENCIALCALCULOOFICINA");

            entity.HasOne(d => d.SecuencialcalculoNavigation).WithMany(p => p.Calculooficinacalculos)
                .HasForeignKey(d => d.Secuencialcalculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CALCULOOFICINACALCULO_CALCULO");

            entity.HasOne(d => d.SecuencialcalculooficinaNavigation).WithMany(p => p.Calculooficinacalculos)
                .HasForeignKey(d => d.Secuencialcalculooficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CALCULOOFICINACALCULO_CALCULOOFICINA");
        });

        modelBuilder.Entity<Cargojuntadirectiva>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PK_CARGO")
                .HasFillFactor(80);

            entity.ToTable("CARGOJUNTADIRECTIVA", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<CondicionCtacblevalorizacion>(entity =>
        {
            entity.HasKey(e => e.Secuencialcondicion).HasFillFactor(80);

            entity.ToTable("CONDICION_CTACBLEVALORIZACION", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialcondicion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALCONDICION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialcuentactablevalorizacion).HasColumnName("SECUENCIALCUENTACTABLEVALORIZACION");

            entity.HasOne(d => d.SecuencialcondicionNavigation).WithOne(p => p.CondicionCtacblevalorizacion)
                .HasForeignKey<CondicionCtacblevalorizacion>(d => d.Secuencialcondicion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONDICION_CTACBLEVALORIZACION_DIVISIONESTRUCTURAACTFIJO_COND");
        });

        modelBuilder.Entity<CondicionCuentacontable>(entity =>
        {
            entity.HasKey(e => e.Secuencialcondicion).HasFillFactor(80);

            entity.ToTable("CONDICION_CUENTACONTABLE", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialcondicion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALCONDICION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Porcentajedepreciaciacion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PORCENTAJEDEPRECIACIACION");
            entity.Property(e => e.Secuencialctacbledepreciacion).HasColumnName("SECUENCIALCTACBLEDEPRECIACION");
            entity.Property(e => e.Secuencialcuentacontabledepreciados).HasColumnName("SECUENCIALCUENTACONTABLEDEPRECIADOS");
            entity.Property(e => e.Secuencialcuentacontablegasto).HasColumnName("SECUENCIALCUENTACONTABLEGASTO");

            entity.HasOne(d => d.SecuencialcondicionNavigation).WithOne(p => p.CondicionCuentacontable)
                .HasForeignKey<CondicionCuentacontable>(d => d.Secuencialcondicion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONDICION_CUENTACONTABLE_DIVISIONESTRUCTURAACTFIJO_COND");
        });

        modelBuilder.Entity<Control>(entity =>
        {
            entity.ToTable("CONTROL", "FBS_ACTIVOSFIJOS", tb => tb.HasComment("Tabla padre para gestion de control de activos fijos"));

            entity.HasIndex(e => new { e.Fecha, e.Secuencialoficina }, "UQ_CONTROL_FECHA_SECUENCIALOFICINA").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(50)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechacliente)
                .HasColumnType("datetime")
                .HasColumnName("FECHACLIENTE");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithMany(p => p.Controls)
                .HasForeignKey(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTROL_OFICINA");
        });

        modelBuilder.Entity<Controldetalle>(entity =>
        {
            entity.ToTable("CONTROLDETALLE", "FBS_ACTIVOSFIJOS", tb => tb.HasComment("Tabla para registrar los activos dentro de cada control de agencias"));

            entity.HasIndex(e => new { e.Idcontrol, e.Secuencialactivo }, "UQ_CONTROLDETALLE_ACTIVOID_IDCONTROL").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(50)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fechacliente)
                .HasColumnType("datetime")
                .HasColumnName("FECHACLIENTE");
            entity.Property(e => e.Idcontrol).HasColumnName("IDCONTROL");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Secuencialpersonaresponsable).HasColumnName("SECUENCIALPERSONARESPONSABLE");

            entity.HasOne(d => d.IdcontrolNavigation).WithMany(p => p.Controldetalles)
                .HasForeignKey(d => d.Idcontrol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTROLDETALLE_CONTROL");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Controldetalles)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTROLDETALLE_ACTIVO");

            entity.HasOne(d => d.SecuencialpersonaresponsableNavigation).WithMany(p => p.Controldetalles)
                .HasForeignKey(d => d.Secuencialpersonaresponsable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTROLDETALLE_PERSONA");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("DEPARTAMENTO_PK")
                .HasFillFactor(80);

            entity.ToTable("DEPARTAMENTO", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Esparaactivosfijos).HasColumnName("ESPARAACTIVOSFIJOS");
            entity.Property(e => e.Esparaproveduria).HasColumnName("ESPARAPROVEDURIA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Siglas)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("SIGLAS");
        });

        modelBuilder.Entity<Directivo>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("DIRECTIVO_PK")
                .HasFillFactor(80);

            entity.ToTable("DIRECTIVO", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(40)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");
        });

        modelBuilder.Entity<Directivoparientevinculado>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("DIRECTIVOPARIENTEVINCULADO_PK")
                .HasFillFactor(80);

            entity.ToTable("DIRECTIVOPARIENTEVINCULADO", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigodirectivo)
                .HasMaxLength(40)
                .HasColumnName("CODIGODIRECTIVO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Identificacionpariente)
                .HasMaxLength(20)
                .HasColumnName("IDENTIFICACIONPARIENTE");
            entity.Property(e => e.Nombreunidopariente)
                .HasMaxLength(200)
                .HasColumnName("NOMBREUNIDOPARIENTE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Parentesco)
                .HasMaxLength(100)
                .HasColumnName("PARENTESCO");

            entity.HasOne(d => d.CodigodirectivoNavigation).WithMany(p => p.Directivoparientevinculados)
                .HasForeignKey(d => d.Codigodirectivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DIRECTIVOPARIENTEVINCULADO_R01");
        });

        modelBuilder.Entity<DivisionestructuraactfijoCond>(entity =>
        {
            entity.HasKey(e => e.Secuencialdivision)
                .HasName("DIVISIONESTRUCTURAACTFIJO_C_PK")
                .HasFillFactor(80);

            entity.ToTable("DIVISIONESTRUCTURAACTFIJO_COND", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialdivision)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialcuentacontableactivo).HasColumnName("SECUENCIALCUENTACONTABLEACTIVO");
            entity.Property(e => e.Sedeprecia).HasColumnName("SEDEPRECIA");
            entity.Property(e => e.Sereexpresa).HasColumnName("SEREEXPRESA");
        });

        modelBuilder.Entity<EmpParmejecucionactivosfijo>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("EMP_PARMEJECUCIONACTIVOSFIJ_PK")
                .HasFillFactor(80);

            entity.ToTable("EMP_PARMEJECUCIONACTIVOSFIJOS", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Diasdepreciacioneventuales).HasColumnName("DIASDEPRECIACIONEVENTUALES");
            entity.Property(e => e.Niveldeterminacondiciones).HasColumnName("NIVELDETERMINACONDICIONES");
            entity.Property(e => e.Numeroniveles).HasColumnName("NUMERONIVELES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Porcentajevalorresidual)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PORCENTAJEVALORRESIDUAL");
            entity.Property(e => e.Reversadepreciaciontotal).HasColumnName("REVERSADEPRECIACIONTOTAL");
            entity.Property(e => e.Sedepreciamensualmente).HasColumnName("SEDEPRECIAMENSUALMENTE");
        });

        modelBuilder.Entity<Estadoactivo>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("ESTADOACTIVO_PK")
                .HasFillFactor(80);

            entity.ToTable("ESTADOACTIVO", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Estadocivil>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("ESTADOCIVIL_PK")
                .HasFillFactor(80);

            entity.ToTable("ESTADOCIVIL", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Requiereconyuge).HasColumnName("REQUIERECONYUGE");
        });

        modelBuilder.Entity<Estadofisicoactivo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("ESTADOFISICOACTIVO", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Estadosolicregistroactadefunc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("ESTADOSOLICREGISTROACTADEFUNC", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<EstructactfijcondCuentasorden>(entity =>
        {
            entity.HasKey(e => e.Secdivisionestruactfijcond).HasFillFactor(80);

            entity.ToTable("ESTRUCTACTFIJCOND_CUENTASORDEN", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secdivisionestruactfijcond)
                .ValueGeneratedNever()
                .HasColumnName("SECDIVISIONESTRUACTFIJCOND");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Seccuentacbleordenacreedora).HasColumnName("SECCUENTACBLEORDENACREEDORA");
            entity.Property(e => e.Seccuentacbleordendeudora).HasColumnName("SECCUENTACBLEORDENDEUDORA");

            entity.HasOne(d => d.SecdivisionestruactfijcondNavigation).WithOne(p => p.EstructactfijcondCuentasorden)
                .HasForeignKey<EstructactfijcondCuentasorden>(d => d.Secdivisionestruactfijcond)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ESTRUCTACTFIJCOND_CUENTASORDEN_DIVISIONESTRUCTURAACTFIJO_COND");
        });

        modelBuilder.Entity<Etnium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("ETNIA", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Huelladigitalpersona>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona).HasFillFactor(80);

            entity.ToTable("HUELLADIGITALPERSONA", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Huelladigital).HasColumnName("HUELLADIGITAL");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.Huelladigitalpersona)
                .HasForeignKey<Huelladigitalpersona>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HUELLADIGITALPERSONA_PERSONA");
        });

        modelBuilder.Entity<Indicecorreccion>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("INDICECORRECCION_PK")
                .HasFillFactor(80);

            entity.ToTable("INDICECORRECCION", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialempresa, e.Secuencialmoneda, e.Fechaperiodo }, "INDICECORRECCION_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Fechaperiodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHAPERIODO");
            entity.Property(e => e.Indice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INDICE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Periodoenmeses).HasColumnName("PERIODOENMESES");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Secuencialmoneda).HasColumnName("SECUENCIALMONEDA");
        });

        modelBuilder.Entity<Juntadirectiva>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("JUNTADIRECTIVA", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.FechaAsamblea)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ASAMBLEA");
            entity.Property(e => e.Fechafinperiodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFINPERIODO");
            entity.Property(e => e.Fechainicioperiodo)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIOPERIODO");
            entity.Property(e => e.Numeroacta).HasColumnName("NUMEROACTA");
            entity.Property(e => e.Numeroresolucion).HasColumnName("NUMERORESOLUCION");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");
        });

        modelBuilder.Entity<Juntadirectivaintegrante>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK_JUNTADIRECTIVAINTEGRANTE")
                .HasFillFactor(80);

            entity.ToTable("JUNTADIRECTIVAINTEGRANTES", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocargojuntadirectiva)
                .HasMaxLength(20)
                .HasColumnName("CODIGOCARGOJUNTADIRECTIVA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialjuntadirectiva).HasColumnName("SECUENCIALJUNTADIRECTIVA");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");

            entity.HasOne(d => d.SecuencialjuntadirectivaNavigation).WithMany(p => p.Juntadirectivaintegrantes)
                .HasForeignKey(d => d.Secuencialjuntadirectiva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JUNTADIRECTIVAINTEGRANTES_JUNTADIRECTIVA1");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithMany(p => p.Juntadirectivaintegrantes)
                .HasForeignKey(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JUNTADIRECTIVAINTEGRANTES_PERSONA_NATURAL");
        });

        modelBuilder.Entity<MotivoActivobaja>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("MOTIVO_ACTIVOBAJA", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialcuentacontable).HasColumnName("SECUENCIALCUENTACONTABLE");
            entity.Property(e => e.Tienecuentabajapropia).HasColumnName("TIENECUENTABAJAPROPIA");
        });

        modelBuilder.Entity<Motivobajdivestructuactfijcond>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("MOTIVOBAJDIVESTRUCTUACTFIJCOND", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => new { e.Secuencialmotivoactivobaja, e.Secdivestructuraactivofijocond }, "IX_MOTIVOBAJDIVESTRUCTUACTFIJCOND")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secdivestructuraactivofijocond).HasColumnName("SECDIVESTRUCTURAACTIVOFIJOCOND");
            entity.Property(e => e.Secuencialcuentacontable).HasColumnName("SECUENCIALCUENTACONTABLE");
            entity.Property(e => e.Secuencialmotivoactivobaja).HasColumnName("SECUENCIALMOTIVOACTIVOBAJA");

            entity.HasOne(d => d.SecdivestructuraactivofijocondNavigation).WithMany(p => p.Motivobajdivestructuactfijconds)
                .HasForeignKey(d => d.Secdivestructuraactivofijocond)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOTIVOBAJDIVESTRUCTUACTFIJCOND_DIVISIONESTRUCTURAACTFIJO_COND");

            entity.HasOne(d => d.SecuencialmotivoactivobajaNavigation).WithMany(p => p.Motivobajdivestructuactfijconds)
                .HasForeignKey(d => d.Secuencialmotivoactivobaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOTIVOBAJDIVESTRUCTUACTFIJCOND_MOTIVO_ACTIVOBAJA");
        });

        modelBuilder.Entity<MovimientocontrolActivo>(entity =>
        {
            entity.HasKey(e => e.Secuencialmovimientocontrol)
                .HasName("MOVIMIENTOCONTROL_ACTIVO_PK")
                .HasFillFactor(80);

            entity.ToTable("MOVIMIENTOCONTROL_ACTIVO", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => e.Secuencialdivestructuraactfijo, "MOVIMIENTOCONTROL_ACTIVO_I01").HasFillFactor(100);

            entity.Property(e => e.Secuencialmovimientocontrol)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALMOVIMIENTOCONTROL");
            entity.Property(e => e.Secuencialcuentacontable).HasColumnName("SECUENCIALCUENTACONTABLE");
            entity.Property(e => e.Secuencialdivestructuraactfijo).HasColumnName("SECUENCIALDIVESTRUCTURAACTFIJO");

            entity.HasOne(d => d.SecuencialdivestructuraactfijoNavigation).WithMany(p => p.MovimientocontrolActivos)
                .HasForeignKey(d => d.Secuencialdivestructuraactfijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIENTOCONTROL_ACTIVO_DIVISIONESTRUCTURAACTFIJO_COND");
        });

        modelBuilder.Entity<NivelCodigointerno>(entity =>
        {
            entity.HasKey(e => e.Secuencialnivel).HasFillFactor(80);

            entity.ToTable("NIVEL_CODIGOINTERNO", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialnivel)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALNIVEL");
            entity.Property(e => e.Codigointerno)
                .HasMaxLength(50)
                .HasColumnName("CODIGOINTERNO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Oficina>(entity =>
        {
            entity.HasKey(e => e.Secuencialdivision)
                .HasName("OFICINA_PK")
                .HasFillFactor(80);

            entity.ToTable("OFICINA", "FBS_ORGANIZACIONES");

            entity.HasIndex(e => e.Secuencialempresa, "OFICINA_I01").HasFillFactor(80);

            entity.Property(e => e.Secuencialdivision)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Cadenaconexionbasedatoslocal)
                .HasMaxLength(500)
                .HasColumnName("CADENACONEXIONBASEDATOSLOCAL");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(60)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Codigooficinacontrol)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("CODIGOOFICINACONTROL");
            entity.Property(e => e.Desconectada).HasColumnName("DESCONECTADA");
            entity.Property(e => e.Esoperativa).HasColumnName("ESOPERATIVA");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Fechacierrecontable)
                .HasColumnType("datetime")
                .HasColumnName("FECHACIERRECONTABLE");
            entity.Property(e => e.Numerocontable).HasColumnName("NUMEROCONTABLE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Puertoswitch).HasColumnName("PUERTOSWITCH");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Servidorimagenes)
                .HasMaxLength(100)
                .HasColumnName("SERVIDORIMAGENES");
            entity.Property(e => e.Servidorswitch)
                .HasMaxLength(500)
                .HasColumnName("SERVIDORSWITCH");
            entity.Property(e => e.Siglas)
                .HasMaxLength(8)
                .HasColumnName("SIGLAS");
        });

        modelBuilder.Entity<OficinaComplemento>(entity =>
        {
            entity.HasKey(e => e.Secuencialoficina).HasFillFactor(80);

            entity.ToTable("OFICINA_COMPLEMENTO", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Secuencialoficina)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALOFICINA");
            entity.Property(e => e.Codigodepartamento)
                .HasMaxLength(2)
                .HasColumnName("codigodepartamento");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivisionpolitica).HasColumnName("SECUENCIALDIVISIONPOLITICA");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithOne(p => p.OficinaComplemento)
                .HasForeignKey<OficinaComplemento>(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OFICINA_COMPLEMENTO_OFICINA");
        });

        modelBuilder.Entity<OficinaComplementosri>(entity =>
        {
            entity.HasKey(e => e.Secuencialoficina)
                .HasName("OFICINA_COMPLEMENTOSRI_PK")
                .HasFillFactor(80);

            entity.ToTable("OFICINA_COMPLEMENTOSRI", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Secuencialoficina)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALOFICINA");
            entity.Property(e => e.Autorizacion)
                .HasMaxLength(100)
                .HasColumnName("AUTORIZACION");
            entity.Property(e => e.Codigoestablecimiento)
                .HasMaxLength(6)
                .HasColumnName("CODIGOESTABLECIMIENTO");
            entity.Property(e => e.Codigoprovinciasri)
                .HasMaxLength(6)
                .HasColumnName("CODIGOPROVINCIASRI");
            entity.Property(e => e.Codigopuntoemision)
                .HasMaxLength(6)
                .HasColumnName("CODIGOPUNTOEMISION");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithOne(p => p.OficinaComplementosri)
                .HasForeignKey<OficinaComplementosri>(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OFICINA_COMPLEMENTOSRI_R01");
        });

        modelBuilder.Entity<OficinaFirmante>(entity =>
        {
            entity.HasKey(e => e.Secuencialoficina)
                .HasName("OFICINA_FIRMANTE_PK")
                .HasFillFactor(80);

            entity.ToTable("OFICINA_FIRMANTE", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Secuencialoficina)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALOFICINA");
            entity.Property(e => e.Codigousuariofirmacarta)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIOFIRMACARTA");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithOne(p => p.OficinaFirmante)
                .HasForeignKey<OficinaFirmante>(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OFICINA_FIRMANTE_R01");
        });

        modelBuilder.Entity<OficinaGeolocalizacion>(entity =>
        {
            entity.HasKey(e => e.Secuencialoficina).HasName("OFICINA_GEOLOCALIZACION_PK");

            entity.ToTable("OFICINA_GEOLOCALIZACION", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Secuencialoficina)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALOFICINA");
            entity.Property(e => e.Latitud)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LONGITUD");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithOne(p => p.OficinaGeolocalizacion)
                .HasForeignKey<OficinaGeolocalizacion>(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OFICINA_GEOLOCALIZACION_R01");
        });

        modelBuilder.Entity<Oficinaarea>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("OFICINAAREA_PK")
                .HasFillFactor(80);

            entity.ToTable("OFICINAAREA", "FBS_ORGANIZACIONES");

            entity.HasIndex(e => e.Secuencialoficina, "IX_OFICINAAREA").HasFillFactor(80);

            entity.HasIndex(e => new { e.Secuencialoficina, e.Secuencialarea }, "OFICINAAREA_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialarea).HasColumnName("SECUENCIALAREA");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");

            entity.HasOne(d => d.SecuencialareaNavigation).WithMany(p => p.Oficinaareas)
                .HasForeignKey(d => d.Secuencialarea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OFICINAAREA_R02");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithMany(p => p.Oficinaareas)
                .HasForeignKey(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OFICINAAREA_R01");
        });

        modelBuilder.Entity<Oficinadepartamento>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("OFICINADEPARTAMENTO_PK")
                .HasFillFactor(80);

            entity.ToTable("OFICINADEPARTAMENTO", "FBS_ORGANIZACIONES");

            entity.HasIndex(e => e.Secuencialoficina, "IX_OFICINADEPARTAMENTO").HasFillFactor(80);

            entity.HasIndex(e => e.Secuencialdepartamento, "IX_OFICINADEPARTAMENTO_1").HasFillFactor(80);

            entity.HasIndex(e => new { e.Secuencialoficina, e.Secuencialdepartamento }, "OFICINADEPARTAMENTO_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdepartamento).HasColumnName("SECUENCIALDEPARTAMENTO");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");

            entity.HasOne(d => d.SecuencialdepartamentoNavigation).WithMany(p => p.Oficinadepartamentos)
                .HasForeignKey(d => d.Secuencialdepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OFICINADEPARTAMENTO_R02");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithMany(p => p.Oficinadepartamentos)
                .HasForeignKey(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OFICINADEPARTAMENTO_R01");
        });

        modelBuilder.Entity<Oficinapdum>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("OFICINAPDA", "FBS_ORGANIZACIONES");

            entity.HasIndex(e => new { e.Secuencialoficina, e.Secuencialpda }, "IX_OFICINAPDA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");
            entity.Property(e => e.Secuencialpda).HasColumnName("SECUENCIALPDA");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithMany(p => p.Oficinapda)
                .HasForeignKey(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OFICINAPDA_OFICINA");

            entity.HasOne(d => d.SecuencialpdaNavigation).WithMany(p => p.Oficinapda)
                .HasForeignKey(d => d.Secuencialpda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OFICINAPDA_PDA");
        });

        modelBuilder.Entity<Oficinapuntoventum>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("OFICINAPUNTOVENTA", "FBS_ORGANIZACIONES");

            entity.HasIndex(e => e.Secuencialoficina, "IX_OFICINAPUNTOVENTA").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithMany(p => p.Oficinapuntoventa)
                .HasForeignKey(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OFICINAPUNTOVENTA_OFICINA");
        });

        modelBuilder.Entity<Oficinazona>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("OFICINAZONA", "FBS_ORGANIZACIONES");

            entity.HasIndex(e => e.Secuencialoficina, "IX_OFICINAZONA")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Secuencialzona, "IX_OFICINAZONA_1").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");
            entity.Property(e => e.Secuencialzona).HasColumnName("SECUENCIALZONA");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithOne(p => p.Oficinazona)
                .HasForeignKey<Oficinazona>(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OFICINAZONA_OFICINA");

            entity.HasOne(d => d.SecuencialzonaNavigation).WithMany(p => p.Oficinazonas)
                .HasForeignKey(d => d.Secuencialzona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OFICINAZONA_ZONA");
        });

        modelBuilder.Entity<Parentesco>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("PARENTESCO", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Esafinidad).HasColumnName("ESAFINIDAD");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Pdum>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK_PDA_1")
                .HasFillFactor(80);

            entity.ToTable("PDA", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<PerNatocupaciondireccion>(entity =>
        {
            entity.HasKey(e => e.Secuencialpernatocupacion).HasFillFactor(80);

            entity.ToTable("PER_NATOCUPACIONDIRECCION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpernatocupacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERNATOCUPACION");
            entity.Property(e => e.Direccionformateada)
                .HasMaxLength(500)
                .HasColumnName("DIRECCIONFORMATEADA");

            entity.HasOne(d => d.SecuencialpernatocupacionNavigation).WithOne(p => p.PerNatocupaciondireccion)
                .HasForeignKey<PerNatocupaciondireccion>(d => d.Secuencialpernatocupacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PER_NATOCUPACIONDIRECCION_PERSONA_NATURALOCUPACION");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PERSONA_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialtipoidentificacion, e.Identificacion }, "PERSONA_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigopaisorigen)
                .HasMaxLength(20)
                .HasColumnName("CODIGOPAISORIGEN");
            entity.Property(e => e.Direcciondomicilio)
                .HasMaxLength(500)
                .HasColumnName("DIRECCIONDOMICILIO");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(40)
                .HasColumnName("IDENTIFICACION");
            entity.Property(e => e.Nombreunido)
                .HasMaxLength(200)
                .HasColumnName("NOMBREUNIDO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Referenciadomiciliaria)
                .HasMaxLength(300)
                .HasColumnName("REFERENCIADOMICILIARIA");
            entity.Property(e => e.Secuencialdivisionactividecon).HasColumnName("SECUENCIALDIVISIONACTIVIDECON");
            entity.Property(e => e.Secuencialtipoidentificacion).HasColumnName("SECUENCIALTIPOIDENTIFICACION");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(1000)
                .HasColumnName("UBICACION");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.Secuencialtipoidentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_R01");
        });

        modelBuilder.Entity<PersonaDireccionformateadum>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona).HasFillFactor(80);

            entity.ToTable("PERSONA_DIRECCIONFORMATEADA", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Calleprincipal)
                .HasMaxLength(500)
                .HasColumnName("CALLEPRINCIPAL");
            entity.Property(e => e.Callesecundaria)
                .HasMaxLength(200)
                .HasColumnName("CALLESECUNDARIA");
            entity.Property(e => e.Direcciondomicilioformateada)
                .HasMaxLength(500)
                .HasColumnName("DIRECCIONDOMICILIOFORMATEADA");
            entity.Property(e => e.Numerocasa)
                .HasMaxLength(30)
                .HasColumnName("NUMEROCASA");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.PersonaDireccionformateadum)
                .HasForeignKey<PersonaDireccionformateadum>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_DIRECCIONFORMATEADA_PERSONA");
        });

        modelBuilder.Entity<PersonaEstado>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona).HasFillFactor(80);

            entity.ToTable("PERSONA_ESTADO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.PersonaEstado)
                .HasForeignKey<PersonaEstado>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_ESTADO_PERSONA");
        });

        modelBuilder.Entity<PersonaFechaultimamodicacion>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona).HasFillFactor(80);

            entity.ToTable("PERSONA_FECHAULTIMAMODICACION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Fechamaquinaultimamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINAULTIMAMODIFICACION");
            entity.Property(e => e.Fechasistemaultimamodificacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMAULTIMAMODIFICACION");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.PersonaFechaultimamodicacion)
                .HasForeignKey<PersonaFechaultimamodicacion>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_FECHAULTIMAMODICACION_PERSONA");
        });

        modelBuilder.Entity<PersonaGeolocation>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasName("PERSONA_GEOLOCATION_PK");

            entity.ToTable("PERSONA_GEOLOCATION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Direccion)
                .HasMaxLength(800)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Latitud)
                .HasMaxLength(50)
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(50)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Parroquia)
                .HasMaxLength(200)
                .HasColumnName("PARROQUIA");
            entity.Property(e => e.Referencia)
                .HasMaxLength(800)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Uuid)
                .HasMaxLength(50)
                .HasColumnName("UUID");
        });

        modelBuilder.Entity<PersonaLugarresidencium>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona).HasFillFactor(80);

            entity.ToTable("PERSONA_LUGARRESIDENCIA", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivisionpolitica).HasColumnName("SECUENCIALDIVISIONPOLITICA");
        });

        modelBuilder.Entity<PersonaNatural>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona)
                .HasName("PERSONA_NATURAL_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_NATURAL", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Apellidomaterno)
                .HasMaxLength(100)
                .HasColumnName("APELLIDOMATERNO");
            entity.Property(e => e.Apellidopaterno)
                .HasMaxLength(100)
                .HasColumnName("APELLIDOPATERNO");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.Cargasfamiliares).HasColumnName("CARGASFAMILIARES");
            entity.Property(e => e.Codigoestadocivil)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGOESTADOCIVIL");
            entity.Property(e => e.Codigoetnia)
                .HasMaxLength(8)
                .HasColumnName("CODIGOETNIA");
            entity.Property(e => e.Codigoprofesion)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("CODIGOPROFESION");
            entity.Property(e => e.Codigotipoeducacion)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGOTIPOEDUCACION");
            entity.Property(e => e.Codigotipovivienda)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGOTIPOVIVIENDA");
            entity.Property(e => e.Egresosmensuales)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EGRESOSMENSUALES");
            entity.Property(e => e.Esmasculino).HasColumnName("ESMASCULINO");
            entity.Property(e => e.Fechanacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHANACIMIENTO");
            entity.Property(e => e.Lugarnacimiento)
                .HasMaxLength(1000)
                .HasColumnName("LUGARNACIMIENTO");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .HasColumnName("NOMBRES");
            entity.Property(e => e.Numerohijos).HasColumnName("NUMEROHIJOS");
            entity.Property(e => e.Patrimonio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PATRIMONIO");
            entity.Property(e => e.Primernombre)
                .HasMaxLength(100)
                .HasColumnName("PRIMERNOMBRE");
            entity.Property(e => e.Segundonombre)
                .HasMaxLength(100)
                .HasColumnName("SEGUNDONOMBRE");

            entity.HasOne(d => d.CodigoestadocivilNavigation).WithMany(p => p.PersonaNaturals)
                .HasForeignKey(d => d.Codigoestadocivil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_NATURAL_R02");

            entity.HasOne(d => d.CodigoetniaNavigation).WithMany(p => p.PersonaNaturals)
                .HasForeignKey(d => d.Codigoetnia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURAL_ETNIA");

            entity.HasOne(d => d.CodigoprofesionNavigation).WithMany(p => p.PersonaNaturals)
                .HasForeignKey(d => d.Codigoprofesion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_NATURAL_R05");

            entity.HasOne(d => d.CodigotipoeducacionNavigation).WithMany(p => p.PersonaNaturals)
                .HasForeignKey(d => d.Codigotipoeducacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_NATURAL_R03");

            entity.HasOne(d => d.CodigotipoviviendaNavigation).WithMany(p => p.PersonaNaturals)
                .HasForeignKey(d => d.Codigotipovivienda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_NATURAL_R04");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.PersonaNatural)
                .HasForeignKey<PersonaNatural>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_NATURAL_R01");
        });

        modelBuilder.Entity<PersonaNaturalArrendatario>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersonanatural)
                .HasName("PK_PERSONA_NATURAL_ARRENDATARIO_1")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_NATURAL_ARRENDATARIO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersonanatural)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Direccion)
                .HasMaxLength(300)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombrearrendatario)
                .HasMaxLength(200)
                .HasColumnName("NOMBREARRENDATARIO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Referenciadomiciliaria)
                .HasMaxLength(300)
                .HasColumnName("REFERENCIADOMICILIARIA");
            entity.Property(e => e.Telefonocelular)
                .HasMaxLength(10)
                .HasColumnName("TELEFONOCELULAR");
            entity.Property(e => e.Telefonofijo)
                .HasMaxLength(10)
                .HasColumnName("TELEFONOFIJO");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithOne(p => p.PersonaNaturalArrendatario)
                .HasForeignKey<PersonaNaturalArrendatario>(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURAL_ARRENDATARIO_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaNaturalConyugue>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersonanatural).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURAL_CONYUGUE", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersonanatural)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombreconyugue)
                .HasMaxLength(200)
                .HasColumnName("NOMBRECONYUGUE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("TELEFONO");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithOne(p => p.PersonaNaturalConyugue)
                .HasForeignKey<PersonaNaturalConyugue>(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURAL_CONYUGUE_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaNaturalFallecimiento>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURAL_FALLECIMIENTO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Secuencialsolicregistactadefun).HasColumnName("SECUENCIALSOLICREGISTACTADEFUN");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.PersonaNaturalFallecimiento)
                .HasForeignKey<PersonaNaturalFallecimiento>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURAL_FALLECIMIENTO_PERSONA_NATURAL");

            entity.HasOne(d => d.SecuencialsolicregistactadefunNavigation).WithMany(p => p.PersonaNaturalFallecimientos)
                .HasForeignKey(d => d.Secuencialsolicregistactadefun)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURAL_FALLECIMIENTO_SOLICITUDREGISTROACTADEFUNCION");
        });

        modelBuilder.Entity<PersonaNaturalLugarnacimiento>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURAL_LUGARNACIMIENTO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivision).HasColumnName("SECUENCIALDIVISION");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.PersonaNaturalLugarnacimiento)
                .HasForeignKey<PersonaNaturalLugarnacimiento>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURAL_LUGARNACIMIENTO_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaNaturalPaisresidencium>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersonanatural)
                .HasName("PK_PERSONA_NATRUAL_PAISRESIDENCIA")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_NATURAL_PAISRESIDENCIA", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersonanatural)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Codigopais)
                .HasMaxLength(20)
                .HasColumnName("CODIGOPAIS");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<PersonaNaturalPersonalizado>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersonanatural).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURAL_PERSONALIZADO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersonanatural)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Anniohabitar).HasColumnName("ANNIOHABITAR");
            entity.Property(e => e.Esdirectivo).HasColumnName("ESDIRECTIVO");
            entity.Property(e => e.Esempleado).HasColumnName("ESEMPLEADO");
            entity.Property(e => e.Mesesresidenciaactual).HasColumnName("MESESRESIDENCIAACTUAL");
            entity.Property(e => e.Meshabitar).HasColumnName("MESHABITAR");
            entity.Property(e => e.Nombrearrendadorresidencia)
                .HasMaxLength(250)
                .HasColumnName("NOMBREARRENDADORRESIDENCIA");
            entity.Property(e => e.Telefonoarrendadorresidencia)
                .HasMaxLength(50)
                .HasColumnName("TELEFONOARRENDADORRESIDENCIA");
            entity.Property(e => e.Valoranticresisresidencia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORANTICRESISRESIDENCIA");
            entity.Property(e => e.Valorarriendoresidencia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORARRIENDORESIDENCIA");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithOne(p => p.PersonaNaturalPersonalizado)
                .HasForeignKey<PersonaNaturalPersonalizado>(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURAL_PERSONALIZADO_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaNaturalbieninmueble>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURALBIENINMUEBLE", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Avaluocomercial)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AVALUOCOMERCIAL");
            entity.Property(e => e.Ciudadnotaria)
                .HasMaxLength(250)
                .HasColumnName("CIUDADNOTARIA");
            entity.Property(e => e.Clase)
                .HasMaxLength(100)
                .HasColumnName("CLASE");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Hipotecadoa)
                .HasMaxLength(250)
                .HasColumnName("HIPOTECADOA");
            entity.Property(e => e.Numeroescritura)
                .HasMaxLength(250)
                .HasColumnName("NUMEROESCRITURA");
            entity.Property(e => e.Numeronotaria).HasColumnName("NUMERONOTARIA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Secuencialubicaciongeografica).HasColumnName("SECUENCIALUBICACIONGEOGRAFICA");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithMany(p => p.PersonaNaturalbieninmuebles)
                .HasForeignKey(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALBIENINMUEBLE_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaNaturalbieninmuebleDireccionformateadum>(entity =>
        {
            entity.HasKey(e => e.SecuencialPersonaNaturalbieninmueble).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURALBIENINMUEBLE_DIRECCIONFORMATEADA", "FBS_PERSONAS");

            entity.Property(e => e.SecuencialPersonaNaturalbieninmueble)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIAL_PERSONA_NATURALBIENINMUEBLE");
            entity.Property(e => e.Calleprincipal)
                .HasMaxLength(500)
                .HasColumnName("CALLEPRINCIPAL");
            entity.Property(e => e.Callesecundaria)
                .HasMaxLength(200)
                .HasColumnName("CALLESECUNDARIA");
            entity.Property(e => e.Direcciondomicilioformateada)
                .HasMaxLength(500)
                .HasColumnName("DIRECCIONDOMICILIOFORMATEADA");
            entity.Property(e => e.Numerocasa)
                .HasMaxLength(30)
                .HasColumnName("NUMEROCASA");

            entity.HasOne(d => d.SecuencialPersonaNaturalbieninmuebleNavigation).WithOne(p => p.PersonaNaturalbieninmuebleDireccionformateadum)
                .HasForeignKey<PersonaNaturalbieninmuebleDireccionformateadum>(d => d.SecuencialPersonaNaturalbieninmueble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALBIENINMUEBLE_DIRECCIONFORMATEADA_PERSONA_NATURALBIENINMUEBLE");
        });

        modelBuilder.Entity<PersonaNaturalconyuge>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURALCONYUGE", "FBS_PERSONAS");

            entity.HasIndex(e => e.Secuencialpersonanatural, "IX_PERSONA_NATURALCONYUGE")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialconyugepersonanat).HasColumnName("SECUENCIALCONYUGEPERSONANAT");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");

            entity.HasOne(d => d.SecuencialconyugepersonanatNavigation).WithMany(p => p.PersonaNaturalconyugeSecuencialconyugepersonanatNavigations)
                .HasForeignKey(d => d.Secuencialconyugepersonanat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALCONYUGE_PERSONA_NATURAL1");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithOne(p => p.PersonaNaturalconyugeSecuencialpersonanaturalNavigation)
                .HasForeignKey<PersonaNaturalconyuge>(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALCONYUGE_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaNaturalfamiliar>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURALFAMILIAR", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersonanatural, e.Secuencialpersonafamiliar, e.Codigoparentesco }, "IX_PERSONA_NATURALFAMILIAR_1")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigoparentesco)
                .HasMaxLength(20)
                .HasColumnName("CODIGOPARENTESCO");
            entity.Property(e => e.Esdependiente).HasColumnName("ESDEPENDIENTE");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersonafamiliar).HasColumnName("SECUENCIALPERSONAFAMILIAR");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Soydependiente).HasColumnName("SOYDEPENDIENTE");

            entity.HasOne(d => d.CodigoparentescoNavigation).WithMany(p => p.PersonaNaturalfamiliars)
                .HasForeignKey(d => d.Codigoparentesco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALFAMILIAR_PARENTESCO1");

            entity.HasOne(d => d.SecuencialpersonafamiliarNavigation).WithMany(p => p.PersonaNaturalfamiliarSecuencialpersonafamiliarNavigations)
                .HasForeignKey(d => d.Secuencialpersonafamiliar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALFAMILIAR_PERSONA_NATURAL1");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithMany(p => p.PersonaNaturalfamiliarSecuencialpersonanaturalNavigations)
                .HasForeignKey(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALFAMILIAR_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaNaturalobligacion>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURALOBLIGACION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Entidad)
                .HasMaxLength(100)
                .HasColumnName("ENTIDAD");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fechavencimiento)
                .HasColumnType("datetime")
                .HasColumnName("FECHAVENCIMIENTO");
            entity.Property(e => e.Formapago)
                .HasMaxLength(100)
                .HasColumnName("FORMAPAGO");
            entity.Property(e => e.Garantia)
                .HasMaxLength(100)
                .HasColumnName("GARANTIA");
            entity.Property(e => e.Montoprestado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MONTOPRESTADO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Plazo).HasColumnName("PLAZO");
            entity.Property(e => e.Saldoactual)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALDOACTUAL");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Valorcuota)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORCUOTA");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithMany(p => p.PersonaNaturalobligacions)
                .HasForeignKey(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALOBLIGACION_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaNaturalocupacion>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PERSONA_NATURALOCUPACION_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_NATURALOCUPACION", "FBS_PERSONAS");

            entity.HasIndex(e => e.Secuencialpersonanatural, "IX_PERSONA_NATURALOCUPACION").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .HasColumnName("CARGO");
            entity.Property(e => e.Codigotipolocal)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGOTIPOLOCAL");
            entity.Property(e => e.Codigotipoocupacion)
                .HasMaxLength(20)
                .HasColumnName("CODIGOTIPOOCUPACION");
            entity.Property(e => e.Descripcionocupacion)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPCIONOCUPACION");
            entity.Property(e => e.Direccion)
                .HasMaxLength(500)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Esnegocio).HasColumnName("ESNEGOCIO");
            entity.Property(e => e.Esprincipal).HasColumnName("ESPRINCIPAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Fechainicio)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.Ingresomensualocupacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INGRESOMENSUALOCUPACION");
            entity.Property(e => e.Lugartrabajo)
                .HasMaxLength(500)
                .HasColumnName("LUGARTRABAJO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Referenciaubicacion)
                .HasMaxLength(300)
                .HasColumnName("REFERENCIAUBICACION");
            entity.Property(e => e.Secuencialdivactividadecon).HasColumnName("SECUENCIALDIVACTIVIDADECON");
            entity.Property(e => e.Secuencialdivpolubicacion).HasColumnName("SECUENCIALDIVPOLUBICACION");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Sueldobase)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SUELDOBASE");
            entity.Property(e => e.Telefonocelular)
                .HasMaxLength(20)
                .HasColumnName("TELEFONOCELULAR");
            entity.Property(e => e.Telefonofijo)
                .HasMaxLength(20)
                .HasColumnName("TELEFONOFIJO");
            entity.Property(e => e.Tiempoexperiencia).HasColumnName("TIEMPOEXPERIENCIA");
            entity.Property(e => e.Tiemposervicio).HasColumnName("TIEMPOSERVICIO");
            entity.Property(e => e.Valoranticresisnegocio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORANTICRESISNEGOCIO");
            entity.Property(e => e.Valorarriendonegocio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORARRIENDONEGOCIO");

            entity.HasOne(d => d.CodigotipolocalNavigation).WithMany(p => p.PersonaNaturalocupacions)
                .HasForeignKey(d => d.Codigotipolocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALOCUPACION_TIPOLOCAL");

            entity.HasOne(d => d.CodigotipoocupacionNavigation).WithMany(p => p.PersonaNaturalocupacions)
                .HasForeignKey(d => d.Codigotipoocupacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALOCUPACION_TIPOOCUPACION");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithMany(p => p.PersonaNaturalocupacions)
                .HasForeignKey(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_NATURALOCUPACION_R01");
        });

        modelBuilder.Entity<PersonaNaturalocupacionGeolocation>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasName("PERSONA_NATURALOCUPACION_GEOLOCATION_PK");

            entity.ToTable("PERSONA_NATURALOCUPACION_GEOLOCATION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Direccion)
                .HasMaxLength(800)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Latitud)
                .HasMaxLength(50)
                .HasColumnName("LATITUD");
            entity.Property(e => e.Longitud)
                .HasMaxLength(50)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Parroquia)
                .HasMaxLength(200)
                .HasColumnName("PARROQUIA");
            entity.Property(e => e.Referencia)
                .HasMaxLength(800)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.SecuencialpersonaNaturalocupacion).HasColumnName("SECUENCIALPERSONA_NATURALOCUPACION");
            entity.Property(e => e.Uuid)
                .HasMaxLength(50)
                .HasColumnName("UUID");
        });

        modelBuilder.Entity<PersonaNaturalocupacionorg>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PERSONA_NATURALOCUPACIONORG_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_NATURALOCUPACIONORG", "FBS_PERSONAS");

            entity.HasIndex(e => e.Secuencialpersonanaturalocu, "PERSONANATURALOCUORG_IX")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Secuencialpersonanaturalocu, e.Secuencialpersonaorganizacion }, "PERSONA_NATURALOCUORG_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersonanaturalocu).HasColumnName("SECUENCIALPERSONANATURALOCU");
            entity.Property(e => e.Secuencialpersonaorganizacion).HasColumnName("SECUENCIALPERSONAORGANIZACION");

            entity.HasOne(d => d.SecuencialpersonanaturalocuNavigation).WithOne(p => p.PersonaNaturalocupacionorg)
                .HasForeignKey<PersonaNaturalocupacionorg>(d => d.Secuencialpersonanaturalocu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_NATURALOCUPACIONORGR01");

            entity.HasOne(d => d.SecuencialpersonaorganizacionNavigation).WithMany(p => p.PersonaNaturalocupacionorgs)
                .HasForeignKey(d => d.Secuencialpersonaorganizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_NATURALOCUPACIONORGR02");
        });

        modelBuilder.Entity<PersonaNaturalvehiculo>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONA_NATURALVEHICULO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Clase)
                .HasMaxLength(100)
                .HasColumnName("CLASE");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .HasColumnName("MODELO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Pignoradoa)
                .HasMaxLength(100)
                .HasColumnName("PIGNORADOA");
            entity.Property(e => e.Placa)
                .HasMaxLength(20)
                .HasColumnName("PLACA");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");
            entity.Property(e => e.Valorcomercial)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALORCOMERCIAL");

            entity.HasOne(d => d.SecuencialpersonanaturalNavigation).WithMany(p => p.PersonaNaturalvehiculos)
                .HasForeignKey(d => d.Secuencialpersonanatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_NATURALVEHICULO_PERSONA_NATURAL");
        });

        modelBuilder.Entity<PersonaOrganizacion>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona)
                .HasName("PERSONAORGANIZACION_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Activostotales)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ACTIVOSTOTALES");
            entity.Property(e => e.Egresosmensuales)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EGRESOSMENSUALES");
            entity.Property(e => e.Fechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREACION");
            entity.Property(e => e.Ingresosmensuales)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INGRESOSMENSUALES");
            entity.Property(e => e.Objetosocial)
                .HasMaxLength(200)
                .HasColumnName("OBJETOSOCIAL");
            entity.Property(e => e.Pasivostotales)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PASIVOSTOTALES");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(200)
                .HasColumnName("RAZONSOCIAL");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.PersonaOrganizacion)
                .HasForeignKey<PersonaOrganizacion>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_ORGANIZACION_R01");
        });

        modelBuilder.Entity<PersonaOrganizacionCompl>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersonaorganizacion)
                .HasName("PERSONA_ORGANIZACION_COMPLE_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACION_COMPL", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersonaorganizacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONAORGANIZACION");
            entity.Property(e => e.Esinstitucionfinanciera).HasColumnName("ESINSTITUCIONFINANCIERA");
            entity.Property(e => e.Essujetoir).HasColumnName("ESSUJETOIR");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialpersonaorganizacionNavigation).WithOne(p => p.PersonaOrganizacionCompl)
                .HasForeignKey<PersonaOrganizacionCompl>(d => d.Secuencialpersonaorganizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_ORGANIZACION_COMPL_R01");
        });

        modelBuilder.Entity<PersonaOrganizacionGrreunion>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACION_GRREUNION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigotiporeunion)
                .HasMaxLength(10)
                .HasColumnName("CODIGOTIPOREUNION");
            entity.Property(e => e.Codigousuarioregistra)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIOREGISTRA");
            entity.Property(e => e.Comentario)
                .HasMaxLength(500)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Hora)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("HORA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersonaorggrupo).HasColumnName("SECUENCIALPERSONAORGGRUPO");
            entity.Property(e => e.Vistobueno).HasColumnName("VISTOBUENO");

            entity.HasOne(d => d.CodigotiporeunionNavigation).WithMany(p => p.PersonaOrganizacionGrreunions)
                .HasForeignKey(d => d.Codigotiporeunion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_ORGANIZACION_GRREUNION_TIPOREUNIONGRUPO");

            entity.HasOne(d => d.SecuencialpersonaorggrupoNavigation).WithMany(p => p.PersonaOrganizacionGrreunions)
                .HasForeignKey(d => d.Secuencialpersonaorggrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_ORGANIZACION_GRREUNION_PERSONA_ORGANIZACION_GRUPO");
        });

        modelBuilder.Entity<PersonaOrganizacionGruintgr>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PERSONA_ORGANIZACION_GRUPOP_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACION_GRUINTGR", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersonaorggrupo, e.Secuencialpersonaintgrgrupo }, "PERSONA_ORG_GRUINTGR_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Secuencialpersonaorggrupo, "PERSONA_ORG_GRUINTGR_I02").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersonaintgrgrupo).HasColumnName("SECUENCIALPERSONAINTGRGRUPO");
            entity.Property(e => e.Secuencialpersonaorggrupo).HasColumnName("SECUENCIALPERSONAORGGRUPO");
            entity.Property(e => e.Tiempovinculaciongrupo).HasColumnName("TIEMPOVINCULACIONGRUPO");

            entity.HasOne(d => d.SecuencialpersonaintgrgrupoNavigation).WithMany(p => p.PersonaOrganizacionGruintgrs)
                .HasForeignKey(d => d.Secuencialpersonaintgrgrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_ORGANIZACION_GRUIN_R02");

            entity.HasOne(d => d.SecuencialpersonaorggrupoNavigation).WithMany(p => p.PersonaOrganizacionGruintgrs)
                .HasForeignKey(d => d.Secuencialpersonaorggrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_ORGANIZACION_GRUIN_R01");
        });

        modelBuilder.Entity<PersonaOrganizacionGrupo>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersonaorganizacion)
                .HasName("PERSONA_ORGANIZACION_GRUPO_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACION_GRUPO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersonaorganizacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONAORGANIZACION");
            entity.Property(e => e.Codigotipogrupo)
                .HasMaxLength(6)
                .HasColumnName("CODIGOTIPOGRUPO");
            entity.Property(e => e.Detalleproyecto)
                .HasMaxLength(500)
                .HasColumnName("DETALLEPROYECTO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Formaadquieremateriaprima)
                .HasMaxLength(500)
                .HasColumnName("FORMAADQUIEREMATERIAPRIMA");
            entity.Property(e => e.Formaventaproductos)
                .HasMaxLength(500)
                .HasColumnName("FORMAVENTAPRODUCTOS");
            entity.Property(e => e.Numerointegrantes).HasColumnName("NUMEROINTEGRANTES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Proyectocomun).HasColumnName("PROYECTOCOMUN");

            entity.HasOne(d => d.CodigotipogrupoNavigation).WithMany(p => p.PersonaOrganizacionGrupos)
                .HasForeignKey(d => d.Codigotipogrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_ORGANIZACION_GRUPO_R02");

            entity.HasOne(d => d.SecuencialpersonaorganizacionNavigation).WithOne(p => p.PersonaOrganizacionGrupo)
                .HasForeignKey<PersonaOrganizacionGrupo>(d => d.Secuencialpersonaorganizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_ORGANIZACION_GRUPO_R01");
        });

        modelBuilder.Entity<PersonaOrganizacionReglegal>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersonaorganizacion)
                .HasName("PERSONA_ORGANIZACION_REGIST_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACION_REGLEGAL", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialpersonaorganizacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONAORGANIZACION");
            entity.Property(e => e.Fechacreacionlegal)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREACIONLEGAL");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Registrolegal)
                .HasMaxLength(100)
                .HasColumnName("REGISTROLEGAL");

            entity.HasOne(d => d.SecuencialpersonaorganizacionNavigation).WithOne(p => p.PersonaOrganizacionReglegal)
                .HasForeignKey<PersonaOrganizacionReglegal>(d => d.Secuencialpersonaorganizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_ORGANIZACION_REGLE_R01");
        });

        modelBuilder.Entity<PersonaOrganizacionaccionistum>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PERSONA_ORGANIZACIONACCIONI_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACIONACCIONISTA", "FBS_PERSONAS");

            entity.HasIndex(e => e.Secuencialpersonaorganizacion, "PERSONA_ORGANIZACIONACCION_I01").HasFillFactor(80);

            entity.HasIndex(e => new { e.Secuencialpersonaorganizacion, e.Identificacion }, "PERSONA_ORGANIZACIONACCION_I02")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(40)
                .HasColumnName("IDENTIFICACION");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .HasColumnName("NOMBRES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersonaorganizacion).HasColumnName("SECUENCIALPERSONAORGANIZACION");
            entity.Property(e => e.Secuencialtipoidentificacion).HasColumnName("SECUENCIALTIPOIDENTIFICACION");
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .HasColumnName("TELEFONO");

            entity.HasOne(d => d.SecuencialpersonaorganizacionNavigation).WithMany(p => p.PersonaOrganizacionaccionista)
                .HasForeignKey(d => d.Secuencialpersonaorganizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PERSONA_ORGANIZACIONACCION_R01");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithMany(p => p.PersonaOrganizacionaccionista)
                .HasForeignKey(d => d.Secuencialtipoidentificacion)
                .HasConstraintName("FK_PERSONA_ORGANIZACIONACCIONISTA_TIPOIDENTIFICACION");
        });

        modelBuilder.Entity<PersonaOrganizacioncontacto>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACIONCONTACTOS", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Cargo)
                .HasMaxLength(250)
                .HasColumnName("CARGO");
            entity.Property(e => e.Celular)
                .HasMaxLength(40)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasColumnName("EXTENSION");
            entity.Property(e => e.Nombresyapellidos)
                .HasMaxLength(500)
                .HasColumnName("NOMBRESYAPELLIDOS");
            entity.Property(e => e.Numerotelefono)
                .HasMaxLength(40)
                .HasColumnName("NUMEROTELEFONO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
            entity.Property(e => e.Profesion)
                .HasMaxLength(250)
                .HasColumnName("PROFESION");
            entity.Property(e => e.Secuencialpersonaorganizacion).HasColumnName("SECUENCIALPERSONAORGANIZACION");

            entity.HasOne(d => d.SecuencialpersonaorganizacionNavigation).WithMany(p => p.PersonaOrganizacioncontactos)
                .HasForeignKey(d => d.Secuencialpersonaorganizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_ORGANIZACIONCONTACTOS_PERSONA_ORGANIZACION");
        });

        modelBuilder.Entity<PersonaOrganizacionocupacion>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PERSONA_ORGANIZOCUPACION_PK")
                .HasFillFactor(80);

            entity.ToTable("PERSONA_ORGANIZACIONOCUPACION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Cargo)
                .HasMaxLength(200)
                .HasColumnName("CARGO");
            entity.Property(e => e.Descripcionocupacion)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPCIONOCUPACION");
            entity.Property(e => e.Direccion)
                .HasMaxLength(500)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Esprincipal).HasColumnName("ESPRINCIPAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Fechainicio)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.Ingresomensualocupacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INGRESOMENSUALOCUPACION");
            entity.Property(e => e.Lugartrabajo)
                .HasMaxLength(500)
                .HasColumnName("LUGARTRABAJO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivactividadecon).HasColumnName("SECUENCIALDIVACTIVIDADECON");
            entity.Property(e => e.Secuencialdivpolubicacion).HasColumnName("SECUENCIALDIVPOLUBICACION");
            entity.Property(e => e.Secuencialpersonaorganizacion).HasColumnName("SECUENCIALPERSONAORGANIZACION");

            entity.HasOne(d => d.SecuencialpersonaorganizacionNavigation).WithMany(p => p.PersonaOrganizacionocupacions)
                .HasForeignKey(d => d.Secuencialpersonaorganizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_ORGANIZACIONOCUPACION_PERSONA_ORGANIZACION");
        });

        modelBuilder.Entity<PersonaResponsable>(entity =>
        {
            entity.HasKey(e => e.Secuencialpersona).HasFillFactor(80);

            entity.ToTable("PERSONA_RESPONSABLE", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialpersona)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialoficinadepartamento).HasColumnName("SECUENCIALOFICINADEPARTAMENTO");

            entity.HasOne(d => d.SecuencialoficinadepartamentoNavigation).WithMany(p => p.PersonaResponsables)
                .HasForeignKey(d => d.Secuencialoficinadepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_RESPONSABLE_OFICINADEPARTAMENTO");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithOne(p => p.PersonaResponsable)
                .HasForeignKey<PersonaResponsable>(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_RESPONSABLE_PERSONA");
        });

        modelBuilder.Entity<Personabooleana>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONABOOLEANA", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersona, e.Codigocaracteristica }, "IX_PERSONABOOLEANA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Valor).HasColumnName("VALOR");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personabooleanas)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONABOOLEANA_PERSONA");
        });

        modelBuilder.Entity<Personacorreo>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONACORREO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigotipocorreo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGOTIPOCORREO");
            entity.Property(e => e.Correoelectronico)
                .HasMaxLength(50)
                .HasColumnName("CORREOELECTRONICO");
            entity.Property(e => e.Esenviotoken).HasColumnName("ESENVIOTOKEN");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personacorreos)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONACORREO_PERSONA");
        });

        modelBuilder.Entity<Personadocumentoadicionalr>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONADOCUMENTOADICIONALR", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersona, e.Secuencialtipodocumentoadicional, e.Identificacion }, "IX_PERSONADOCUMENTOADICIONALR")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Secuencialpersona, e.Estaactivo }, "IX_PERSONADOCUMENTOADICIONALR_1").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .HasColumnName("IDENTIFICACION");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Secuencialtipodocumentoadicional).HasColumnName("SECUENCIALTIPODOCUMENTOADICIONAL");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personadocumentoadicionalrs)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONADOCUMENTOADICIONALR_PERSONA");

            entity.HasOne(d => d.SecuencialtipodocumentoadicionalNavigation).WithMany(p => p.Personadocumentoadicionalrs)
                .HasForeignKey(d => d.Secuencialtipodocumentoadicional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONADOCUMENTOADICIONALR_TIPOIDENTIFICACION");
        });

        modelBuilder.Entity<Personafamiliar>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONAFAMILIAR", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigoparentesco)
                .HasMaxLength(20)
                .HasColumnName("CODIGOPARENTESCO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersonafamiliar).HasColumnName("SECUENCIALPERSONAFAMILIAR");
            entity.Property(e => e.Secuencialpersonanatural).HasColumnName("SECUENCIALPERSONANATURAL");
        });

        modelBuilder.Entity<Personafecha>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONAFECHA", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersona, e.Codigocaracteristica }, "IX_PERSONAFECHA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Valor)
                .HasColumnType("datetime")
                .HasColumnName("VALOR");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personafechas)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONAFECHA_PERSONA");
        });

        modelBuilder.Entity<Personainfoburo>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONAINFOBURO", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersona, e.Secuencialempresaburocredito }, "IX_PERSONAINFOBURO").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Consultasatisfactoria).HasColumnName("CONSULTASATISFACTORIA");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Infoburo).HasColumnName("INFOBURO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresaburocredito).HasColumnName("SECUENCIALEMPRESABUROCREDITO");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personainfoburos)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONAINFOBURO_PERSONA");
        });

        modelBuilder.Entity<Personalistum>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONALISTA", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersona, e.Secuencialcaracteristicalista }, "IX_PERSONALISTA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialcaracteristicalista).HasColumnName("SECUENCIALCARACTERISTICALISTA");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personalista)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONALISTA_PERSONA");
        });

        modelBuilder.Entity<Personanumerica>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONANUMERICA", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersona, e.Codigocaracteristica }, "IX_PERSONANUMERICA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Valordecimal).HasColumnName("VALORDECIMAL");
            entity.Property(e => e.Valorentero).HasColumnName("VALORENTERO");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personanumericas)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONANUMERICA_PERSONA");
        });

        modelBuilder.Entity<Personaproveedor>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONAPROVEEDOR", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personaproveedors)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONAPROVEEDOR_PERSONA");
        });

        modelBuilder.Entity<Personatexto>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PERSONATEXTO", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersona, e.Codigocaracteristica }, "IX_PERSONATEXTO")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Valor)
                .HasMaxLength(500)
                .HasColumnName("VALOR");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Personatextos)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONATEXTO_PERSONA");
        });

        modelBuilder.Entity<Profesion>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PROFESION_PK")
                .HasFillFactor(80);

            entity.ToTable("PROFESION", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<PuntodeventaDepartamento>(entity =>
        {
            entity.HasKey(e => e.Secuencialoficinpuntoventa).HasFillFactor(80);

            entity.ToTable("PUNTODEVENTA_DEPARTAMENTO", "FBS_ORGANIZACIONES");

            entity.HasIndex(e => new { e.Secuencialoficinpuntoventa, e.Secuencialdepartamento }, "IX_PUNTODEVENTA_DEPARTAMENTO")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencialoficinpuntoventa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALOFICINPUNTOVENTA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdepartamento).HasColumnName("SECUENCIALDEPARTAMENTO");

            entity.HasOne(d => d.SecuencialdepartamentoNavigation).WithMany(p => p.PuntodeventaDepartamentos)
                .HasForeignKey(d => d.Secuencialdepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PUNTODEVENTA_DEPARTAMENTO_DEPARTAMENTO");

            entity.HasOne(d => d.SecuencialoficinpuntoventaNavigation).WithOne(p => p.PuntodeventaDepartamento)
                .HasForeignKey<PuntodeventaDepartamento>(d => d.Secuencialoficinpuntoventa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PUNTODEVENTA_DEPARTAMENTO_OFICINAPUNTOVENTA");
        });

        modelBuilder.Entity<Rangoedad>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("RANGOEDAD_PK")
                .HasFillFactor(80);

            entity.ToTable("RANGOEDAD", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Edadfinal).HasColumnName("EDADFINAL");
            entity.Property(e => e.Edadinicio).HasColumnName("EDADINICIO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Referenciabancarium>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("REFERENCIABANCARIA_PK")
                .HasFillFactor(80);

            entity.ToTable("REFERENCIABANCARIA", "FBS_PERSONAS");

            entity.HasIndex(e => e.Secuencialpersona, "REFERENCIABANCARIA_I01").HasFillFactor(100);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigotipocuentareferencia)
                .HasMaxLength(20)
                .HasColumnName("CODIGOTIPOCUENTAREFERENCIA");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numerocuenta)
                .HasMaxLength(60)
                .HasColumnName("NUMEROCUENTA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialbanco).HasColumnName("SECUENCIALBANCO");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");

            entity.HasOne(d => d.CodigotipocuentareferenciaNavigation).WithMany(p => p.Referenciabancaria)
                .HasForeignKey(d => d.Codigotipocuentareferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REFERENCIABANCARIA_R03");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Referenciabancaria)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REFERENCIABANCARIA_R01");
        });

        modelBuilder.Entity<Referenciacomercial>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("REFERENCIACOMERCIAL", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Direccion)
                .HasMaxLength(500)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .HasColumnName("NOMBRES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .HasColumnName("TELEFONO");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Referenciacomercials)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REFERENCIACOMERCIAL_PERSONA");
        });

        modelBuilder.Entity<Referencium>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("REFERENCIA_PK")
                .HasFillFactor(80);

            entity.ToTable("REFERENCIA", "FBS_PERSONAS");

            entity.HasIndex(e => e.Secuencialpersona, "REFERENCIA_I01").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Actividad)
                .HasMaxLength(40)
                .HasColumnName("ACTIVIDAD");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.Direccion)
                .HasMaxLength(500)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Direccionactividad)
                .HasMaxLength(500)
                .HasColumnName("DIRECCIONACTIVIDAD");
            entity.Property(e => e.Espersonal).HasColumnName("ESPERSONAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .HasColumnName("NOMBRES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Parentesco)
                .HasMaxLength(40)
                .HasColumnName("PARENTESCO");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(40)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Telefonoactividad)
                .HasMaxLength(40)
                .HasColumnName("TELEFONOACTIVIDAD");
            entity.Property(e => e.Telefonocelular)
                .HasMaxLength(40)
                .HasColumnName("TELEFONOCELULAR");
            entity.Property(e => e.Telefonocelularactividad)
                .HasMaxLength(40)
                .HasColumnName("TELEFONOCELULARACTIVIDAD");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Referencia)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REFERENCIA_R01");
        });

        modelBuilder.Entity<Representante>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("REPRESENTANTE_PK")
                .HasFillFactor(80);

            entity.ToTable("REPRESENTANTE", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigotiporepresentante)
                .HasMaxLength(10)
                .HasColumnName("CODIGOTIPOREPRESENTANTE");
            entity.Property(e => e.Esprincipal).HasColumnName("ESPRINCIPAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
            entity.Property(e => e.Secuencialpersonanaturalrepr).HasColumnName("SECUENCIALPERSONANATURALREPR");

            entity.HasOne(d => d.CodigotiporepresentanteNavigation).WithMany(p => p.Representantes)
                .HasForeignKey(d => d.Codigotiporepresentante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REPRESENTANTE_TIPOREPRESENTANTE");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Representantes)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REPRESENTANTE_R01");

            entity.HasOne(d => d.SecuencialpersonanaturalreprNavigation).WithMany(p => p.Representantes)
                .HasForeignKey(d => d.Secuencialpersonanaturalrepr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REPRESENTANTE_PERSONA_NATURAL");
        });

        modelBuilder.Entity<Representantehistorico>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("REPRESENTANTEHISTORICO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuarioingreso)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIOINGRESO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
        });

        modelBuilder.Entity<Representantehistoricodetalle>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("REPRESENTANTEHISTORICODETALLE", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Esprincipal).HasColumnName("ESPRINCIPAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombretiporepresentante)
                .HasMaxLength(50)
                .HasColumnName("NOMBRETIPOREPRESENTANTE");
            entity.Property(e => e.Secrepresentantehistorico).HasColumnName("SECREPRESENTANTEHISTORICO");
            entity.Property(e => e.Secuencialpersonanaturalrepr).HasColumnName("SECUENCIALPERSONANATURALREPR");

            entity.HasOne(d => d.SecrepresentantehistoricoNavigation).WithMany(p => p.Representantehistoricodetalles)
                .HasForeignKey(d => d.Secrepresentantehistorico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REPRESENTANTEHISTORICODETALLE_REPRESENTANTEHISTORICO");
        });

        modelBuilder.Entity<Solicitudactivobaja>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("SOLICITUDACTIVOBAJA", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigoestsolicitudactivobaja)
                .HasMaxLength(10)
                .HasColumnName("CODIGOESTSOLICITUDACTIVOBAJA");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Comentariobaja)
                .HasMaxLength(100)
                .HasColumnName("COMENTARIOBAJA");
            entity.Property(e => e.Eseventual).HasColumnName("ESEVENTUAL");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Secuencialmotivobaja).HasColumnName("SECUENCIALMOTIVOBAJA");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Solicitudactivobajas)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUDACTIVOBAJA_ACTIVO");

            entity.HasOne(d => d.SecuencialmotivobajaNavigation).WithMany(p => p.Solicitudactivobajas)
                .HasForeignKey(d => d.Secuencialmotivobaja)
                .HasConstraintName("FK_SOLICITUDACTIVOBAJA_MOTIVO_ACTIVOBAJA");

            entity.HasOne(d => d.SecuencialoficinaNavigation).WithMany(p => p.Solicitudactivobajas)
                .HasForeignKey(d => d.Secuencialoficina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUDACTIVOBAJA_OFICINA");
        });

        modelBuilder.Entity<SolicitudactivobajaCompcausal>(entity =>
        {
            entity.HasKey(e => e.Secuencialactivobaja).HasFillFactor(80);

            entity.ToTable("SOLICITUDACTIVOBAJA_COMPCAUSAL", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencialactivobaja)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALACTIVOBAJA");
            entity.Property(e => e.Secuencialcomponentecausal).HasColumnName("SECUENCIALCOMPONENTECAUSAL");

            entity.HasOne(d => d.SecuencialactivobajaNavigation).WithOne(p => p.SolicitudactivobajaCompcausal)
                .HasForeignKey<SolicitudactivobajaCompcausal>(d => d.Secuencialactivobaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUDACTIVOBAJA_COMPCAUSAL_SOLICITUDACTIVOBAJA");
        });

        modelBuilder.Entity<Solicitudactivobajacambioest>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("SOLICITUDACTIVOBAJACAMBIOEST", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigoestsolicitudactivobaja)
                .HasMaxLength(10)
                .HasColumnName("CODIGOESTSOLICITUDACTIVOBAJA");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Secuencialsolicitudactivobaja).HasColumnName("SECUENCIALSOLICITUDACTIVOBAJA");

            entity.HasOne(d => d.SecuencialsolicitudactivobajaNavigation).WithMany(p => p.Solicitudactivobajacambioests)
                .HasForeignKey(d => d.Secuencialsolicitudactivobaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUDACTIVOBAJACAMBIOEST_SOLICITUDACTIVOBAJA");
        });

        modelBuilder.Entity<Solicitudactivobajalote>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("SOLICITUDACTIVOBAJALOTE", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Secuencialactivobajalote).HasColumnName("SECUENCIALACTIVOBAJALOTE");
            entity.Property(e => e.Secuencialsolicitudactivobaja).HasColumnName("SECUENCIALSOLICITUDACTIVOBAJA");

            entity.HasOne(d => d.SecuencialactivobajaloteNavigation).WithMany(p => p.Solicitudactivobajalotes)
                .HasForeignKey(d => d.Secuencialactivobajalote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUDACTIVOBAJALOTE_ACTIVOBAJALOTE");

            entity.HasOne(d => d.SecuencialsolicitudactivobajaNavigation).WithMany(p => p.Solicitudactivobajalotes)
                .HasForeignKey(d => d.Secuencialsolicitudactivobaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUDACTIVOBAJALOTE_SOLICITUDACTIVOBAJA");
        });

        modelBuilder.Entity<Solicitudregistroactadefuncion>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("SOLICITUDREGISTROACTADEFUNCION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigoestado)
                .HasMaxLength(20)
                .HasColumnName("CODIGOESTADO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Fechaactadefuncion).HasColumnName("FECHAACTADEFUNCION");
            entity.Property(e => e.Fechafallecimiento).HasColumnName("FECHAFALLECIMIENTO");
            entity.Property(e => e.Fechasistema).HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Numeroregistroacta)
                .HasMaxLength(20)
                .HasColumnName("NUMEROREGISTROACTA");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .HasColumnName("OBSERVACION");
            entity.Property(e => e.SecuencialpersonaNatural).HasColumnName("SECUENCIALPERSONA_NATURAL");

            entity.HasOne(d => d.CodigoestadoNavigation).WithMany(p => p.Solicitudregistroactadefuncions)
                .HasForeignKey(d => d.Codigoestado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUDREGISTROACTADEFUNCION_ESTADOSOLICREGISTROACTADEFUNC");

            entity.HasOne(d => d.SecuencialpersonaNaturalNavigation).WithMany(p => p.Solicitudregistroactadefuncions)
                .HasForeignKey(d => d.SecuencialpersonaNatural)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOLICITUDREGISTROACTADEFUNCION_PERSONA_NATURAL");
        });

        modelBuilder.Entity<Telefonopersona>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TELEFONOPERSONA_PK")
                .HasFillFactor(80);

            entity.ToTable("TELEFONOPERSONA", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialpersona, e.Codigotipotelefono, e.Estaactivo }, "IX_TELEFONOPERSONA").HasFillFactor(80);

            entity.HasIndex(e => e.Secuencialpersona, "TELEFONOPERSONA_I01").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigoempresatelefonica)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("CODIGOEMPRESATELEFONICA");
            entity.Property(e => e.Codigotipotelefono)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGOTIPOTELEFONO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Enviosms).HasColumnName("ENVIOSMS");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numerotelefono)
                .HasMaxLength(40)
                .HasColumnName("NUMEROTELEFONO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");

            entity.HasOne(d => d.SecuencialpersonaNavigation).WithMany(p => p.Telefonopersonas)
                .HasForeignKey(d => d.Secuencialpersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TELEFONOPERSONA_PERSONA");
        });

        modelBuilder.Entity<Telefonopersonahistorico>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("TELEFONOPERSONAHISTORICO", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Estaactivo, e.Secuencialpersona }, "IX_TELEFONOPERSONAHISTORICO").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuarioingreso)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIOINGRESO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");
        });

        modelBuilder.Entity<Telpersonahistoricodetalle>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("TELPERSONAHISTORICODETALLE", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Enviosms).HasColumnName("ENVIOSMS");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombreempresatelefonica)
                .HasMaxLength(100)
                .HasColumnName("NOMBREEMPRESATELEFONICA");
            entity.Property(e => e.Nombretipotelefono)
                .HasMaxLength(100)
                .HasColumnName("NOMBRETIPOTELEFONO");
            entity.Property(e => e.Numerotelefono)
                .HasMaxLength(40)
                .HasColumnName("NUMEROTELEFONO");
            entity.Property(e => e.Sectelefonopersonahistorico).HasColumnName("SECTELEFONOPERSONAHISTORICO");

            entity.HasOne(d => d.SectelefonopersonahistoricoNavigation).WithMany(p => p.Telpersonahistoricodetalles)
                .HasForeignKey(d => d.Sectelefonopersonahistorico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TELPERSONAHISTORICODETALLE_TELEFONOPERSONAHISTORICO");
        });

        modelBuilder.Entity<Tipoarea>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("TIPOAREA", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Siglas)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("SIGLAS");
        });

        modelBuilder.Entity<Tipocuentareferenciabancarium>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("TIPOCUENTAREFERENCIABANCARIAPK")
                .HasFillFactor(80);

            entity.ToTable("TIPOCUENTAREFERENCIABANCARIA", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Siglas)
                .HasMaxLength(50)
                .HasColumnName("SIGLAS");
        });

        modelBuilder.Entity<Tipodocumentoadicional>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("TIPODOCUMENTOADICIONAL", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numerominimoreferenciasbancari).HasColumnName("NUMEROMINIMOREFERENCIASBANCARI");
            entity.Property(e => e.Numerominimoreferenciascomerci).HasColumnName("NUMEROMINIMOREFERENCIASCOMERCI");
            entity.Property(e => e.Numerominimoreferenciaspersona).HasColumnName("NUMEROMINIMOREFERENCIASPERSONA");
            entity.Property(e => e.Numerominimorepresentantes).HasColumnName("NUMEROMINIMOREPRESENTANTES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Parapersonajuridica).HasColumnName("PARAPERSONAJURIDICA");
            entity.Property(e => e.Parapersonanatural).HasColumnName("PARAPERSONANATURAL");
            entity.Property(e => e.Siglas)
                .HasMaxLength(50)
                .HasColumnName("SIGLAS");
        });

        modelBuilder.Entity<TipodocumentoadicionalAutomatica>(entity =>
        {
            entity.HasKey(e => e.Secuencialtipodocumentoadicional).HasFillFactor(80);

            entity.ToTable("TIPODOCUMENTOADICIONAL_AUTOMATICA", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialtipodocumentoadicional)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALTIPODOCUMENTOADICIONAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numerocaracteressinprepostcod).HasColumnName("NUMEROCARACTERESSINPREPOSTCOD");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Postcodigo)
                .HasMaxLength(10)
                .HasColumnName("POSTCODIGO");
            entity.Property(e => e.Precodigo)
                .HasMaxLength(10)
                .HasColumnName("PRECODIGO");
            entity.Property(e => e.Ultimosecuencial).HasColumnName("ULTIMOSECUENCIAL");

            entity.HasOne(d => d.SecuencialtipodocumentoadicionalNavigation).WithOne(p => p.TipodocumentoadicionalAutomatica)
                .HasForeignKey<TipodocumentoadicionalAutomatica>(d => d.Secuencialtipodocumentoadicional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPODOCUMENTOADICIONAL_AUTOMATICA_TIPODOCUMENTOADICIONAL");
        });

        modelBuilder.Entity<TipodocumentoadicionalFormato>(entity =>
        {
            entity.HasKey(e => e.Secuencialtipodocumentoadicional).HasFillFactor(80);

            entity.ToTable("TIPODOCUMENTOADICIONAL_FORMATO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialtipodocumentoadicional)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALTIPODOCUMENTOADICIONAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Formato)
                .HasMaxLength(50)
                .HasColumnName("FORMATO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialtipodocumentoadicionalNavigation).WithOne(p => p.TipodocumentoadicionalFormato)
                .HasForeignKey<TipodocumentoadicionalFormato>(d => d.Secuencialtipodocumentoadicional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPODOCUMENTOADICIONAL_FORMATO_TIPODOCUMENTOADICIONAL");
        });

        modelBuilder.Entity<TipodocumentoadicionalMetodo>(entity =>
        {
            entity.HasKey(e => e.Secuencialtipodocumentoadicional).HasFillFactor(80);

            entity.ToTable("TIPODOCUMENTOADICIONAL_METODO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialtipodocumentoadicional)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALTIPODOCUMENTOADICIONAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombremetodovalidaid)
                .HasMaxLength(100)
                .HasColumnName("NOMBREMETODOVALIDAID");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Utilizaservicio).HasColumnName("UTILIZASERVICIO");

            entity.HasOne(d => d.SecuencialtipodocumentoadicionalNavigation).WithOne(p => p.TipodocumentoadicionalMetodo)
                .HasForeignKey<TipodocumentoadicionalMetodo>(d => d.Secuencialtipodocumentoadicional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPODOCUMENTOADICIONAL_METODO_TIPODOCUMENTOADICIONAL");
        });

        modelBuilder.Entity<Tipoeducacion>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("TIPOEDUCACION_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOEDUCACION", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Aceptaprofesion).HasColumnName("ACEPTAPROFESION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipogrupo>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("TIPOGRUPO_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOGRUPO", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Aceptaproyectocomun).HasColumnName("ACEPTAPROYECTOCOMUN");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroderepresentantes).HasColumnName("NUMERODEREPRESENTANTES");
            entity.Property(e => e.Numeromaximodeintegrantes).HasColumnName("NUMEROMAXIMODEINTEGRANTES");
            entity.Property(e => e.Numerominimodeintegrantes).HasColumnName("NUMEROMINIMODEINTEGRANTES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipoidentificacion>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TIPOIDENTIFICACION_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACION", "FBS_PERSONAS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numerominimoreferenciasbancari).HasColumnName("NUMEROMINIMOREFERENCIASBANCARI");
            entity.Property(e => e.Numerominimoreferenciascomerci).HasColumnName("NUMEROMINIMOREFERENCIASCOMERCI");
            entity.Property(e => e.Numerominimoreferenciaspersona).HasColumnName("NUMEROMINIMOREFERENCIASPERSONA");
            entity.Property(e => e.Numerominimorepresentantes).HasColumnName("NUMEROMINIMOREPRESENTANTES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Parapersonajuridica).HasColumnName("PARAPERSONAJURIDICA");
            entity.Property(e => e.Parapersonanatural).HasColumnName("PARAPERSONANATURAL");
            entity.Property(e => e.Siglas)
                .HasMaxLength(50)
                .HasColumnName("SIGLAS");
        });

        modelBuilder.Entity<TipoidentificacionAutomatica>(entity =>
        {
            entity.HasKey(e => e.Secuencialtipoidentificacion)
                .HasName("TIPOIDENTIFICACION_AUTOMATI_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACION_AUTOMATICA", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialtipoidentificacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALTIPOIDENTIFICACION");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numerocaracteressinprepostcod).HasColumnName("NUMEROCARACTERESSINPREPOSTCOD");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Postcodigo)
                .HasMaxLength(10)
                .HasColumnName("POSTCODIGO");
            entity.Property(e => e.Precodigo)
                .HasMaxLength(10)
                .HasColumnName("PRECODIGO");
            entity.Property(e => e.Ultimosecuencial).HasColumnName("ULTIMOSECUENCIAL");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithOne(p => p.TipoidentificacionAutomatica)
                .HasForeignKey<TipoidentificacionAutomatica>(d => d.Secuencialtipoidentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TIPOIDENTIFICACION_AUTOMAT_R01");
        });

        modelBuilder.Entity<TipoidentificacionCambio>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TIPOIDENTIFICACION_CAMBIO_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACION_CAMBIO", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialtipoidorigen, e.Secuencialtipoiddestino }, "TIPOIDENTIFICACION_CAMBIO_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialtipoiddestino).HasColumnName("SECUENCIALTIPOIDDESTINO");
            entity.Property(e => e.Secuencialtipoidorigen).HasColumnName("SECUENCIALTIPOIDORIGEN");

            entity.HasOne(d => d.SecuencialtipoiddestinoNavigation).WithMany(p => p.TipoidentificacionCambioSecuencialtipoiddestinoNavigations)
                .HasForeignKey(d => d.Secuencialtipoiddestino)
                .HasConstraintName("TIPOIDENTIFICACION_CAMBIO_R02");

            entity.HasOne(d => d.SecuencialtipoidorigenNavigation).WithMany(p => p.TipoidentificacionCambioSecuencialtipoidorigenNavigations)
                .HasForeignKey(d => d.Secuencialtipoidorigen)
                .HasConstraintName("TIPOIDENTIFICACION_CAMBIO_R01");
        });

        modelBuilder.Entity<TipoidentificacionCodcrerep>(entity =>
        {
            entity.HasKey(e => e.Secuencialtipoidentificacion)
                .HasName("TIPOIDENTIFICACION_CODCREREPPK")
                .HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACION_CODCREREP", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialtipoidentificacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALTIPOIDENTIFICACION");
            entity.Property(e => e.Codigocreditreport)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGOCREDITREPORT");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithOne(p => p.TipoidentificacionCodcrerep)
                .HasForeignKey<TipoidentificacionCodcrerep>(d => d.Secuencialtipoidentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TIPOIDENTIFICACION_CODCRER_R01");
        });

        modelBuilder.Entity<TipoidentificacionFormato>(entity =>
        {
            entity.HasKey(e => e.Secuencialtipoidentificacion)
                .HasName("TIPOIDENTIFICACION_FORMA_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACION_FORMATO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialtipoidentificacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALTIPOIDENTIFICACION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Formato)
                .HasMaxLength(50)
                .HasColumnName("FORMATO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithOne(p => p.TipoidentificacionFormato)
                .HasForeignKey<TipoidentificacionFormato>(d => d.Secuencialtipoidentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TIPOIDENTIFICACION_FORMATO_R02");
        });

        modelBuilder.Entity<TipoidentificacionMetodo>(entity =>
        {
            entity.HasKey(e => e.Secuencialtipoidentificacion)
                .HasName("TIPOIDENTIFICACION_METODO_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACION_METODO", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialtipoidentificacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALTIPOIDENTIFICACION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombremetodovalidaid)
                .HasMaxLength(100)
                .HasColumnName("NOMBREMETODOVALIDAID");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Utilizaservicio).HasColumnName("UTILIZASERVICIO");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithOne(p => p.TipoidentificacionMetodo)
                .HasForeignKey<TipoidentificacionMetodo>(d => d.Secuencialtipoidentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TIPOIDENTIFICACION_METODO_R01");
        });

        modelBuilder.Entity<TipoidentificacionRdep>(entity =>
        {
            entity.HasKey(e => e.Secuencialtipoidentificacion).HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACION_RDEP", "FBS_PERSONAS");

            entity.Property(e => e.Secuencialtipoidentificacion)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALTIPOIDENTIFICACION");
            entity.Property(e => e.Codigordep)
                .HasMaxLength(1)
                .HasColumnName("CODIGORDEP");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithOne(p => p.TipoidentificacionRdep)
                .HasForeignKey<TipoidentificacionRdep>(d => d.Secuencialtipoidentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TIPOIDENTIFICACION_RDEP_TIPOIDENTIFICACION");
        });

        modelBuilder.Entity<Tipoidentificacionpai>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TIPOIDENTIFICACIONPAIS_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACIONPAIS", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialtipoidentificacion, e.Codigopais }, "TIPOIDENTIFICACIONPAIS_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigopais)
                .HasMaxLength(20)
                .HasColumnName("CODIGOPAIS");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialtipoidentificacion).HasColumnName("SECUENCIALTIPOIDENTIFICACION");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithMany(p => p.Tipoidentificacionpais)
                .HasForeignKey(d => d.Secuencialtipoidentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TIPOIDENTIFICACIONPAIS_R01");
        });

        modelBuilder.Entity<Tipoidentificacionrangoedad>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TIPOIDENTIFICACIONRANGOEDAD_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOIDENTIFICACIONRANGOEDAD", "FBS_PERSONAS");

            entity.HasIndex(e => new { e.Secuencialtipoidentificacion, e.Codigorangoedad }, "TIPOIDRANGOEDAD_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigorangoedad)
                .HasMaxLength(20)
                .HasColumnName("CODIGORANGOEDAD");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialtipoidentificacion).HasColumnName("SECUENCIALTIPOIDENTIFICACION");

            entity.HasOne(d => d.CodigorangoedadNavigation).WithMany(p => p.Tipoidentificacionrangoedads)
                .HasForeignKey(d => d.Codigorangoedad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C0031836");

            entity.HasOne(d => d.SecuencialtipoidentificacionNavigation).WithMany(p => p.Tipoidentificacionrangoedads)
                .HasForeignKey(d => d.Secuencialtipoidentificacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TIPOIDENTIFICACIONRANGOEDADR01");
        });

        modelBuilder.Entity<Tipolocal>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("TIPOLOCAL", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Esperteneciente).HasColumnName("ESPERTENECIENTE");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipoocupacion>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("TIPOOCUPACION", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Paradependiente).HasColumnName("PARADEPENDIENTE");
            entity.Property(e => e.Requieretipolocal).HasColumnName("REQUIERETIPOLOCAL");
        });

        modelBuilder.Entity<Tiporepresentante>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("TIPOREPRESENTANTE", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tiporeuniongrupo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("TIPOREUNIONGRUPO", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipoviviendum>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("TIPOVIVIENDA_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOVIVIENDA", "FBS_PERSONAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Esperteneciente).HasColumnName("ESPERTENECIENTE");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Traslado>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TRASLADO_PK")
                .HasFillFactor(80);

            entity.ToTable("TRASLADO", "FBS_ACTIVOSFIJOS");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigoestadotraslado)
                .HasMaxLength(30)
                .HasColumnName("CODIGOESTADOTRASLADO");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Concepto)
                .HasMaxLength(300)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Trasladodetalle>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TRASLADODETALLE_PK")
                .HasFillFactor(80);

            entity.ToTable("TRASLADODETALLE", "FBS_ACTIVOSFIJOS");

            entity.HasIndex(e => e.Secuencialtraslado, "TRASLADODETALLE_I01").HasFillFactor(80);

            entity.HasIndex(e => new { e.Secuencialtraslado, e.Secuencialactivo }, "TRASLADODETALLE_I02")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secoficinadepartamentodestino).HasColumnName("SECOFICINADEPARTAMENTODESTINO");
            entity.Property(e => e.Secoficinadepartamentoorigen).HasColumnName("SECOFICINADEPARTAMENTOORIGEN");
            entity.Property(e => e.Secpersonaresponsabledestino).HasColumnName("SECPERSONARESPONSABLEDESTINO");
            entity.Property(e => e.Secpersonaresponsableorigen).HasColumnName("SECPERSONARESPONSABLEORIGEN");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");
            entity.Property(e => e.Secuencialtraslado).HasColumnName("SECUENCIALTRASLADO");

            entity.HasOne(d => d.SecoficinadepartamentodestinoNavigation).WithMany(p => p.TrasladodetalleSecoficinadepartamentodestinoNavigations)
                .HasForeignKey(d => d.Secoficinadepartamentodestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRASLADODETALLE_DEPARTAMENTO");

            entity.HasOne(d => d.SecoficinadepartamentoorigenNavigation).WithMany(p => p.TrasladodetalleSecoficinadepartamentoorigenNavigations)
                .HasForeignKey(d => d.Secoficinadepartamentoorigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRASLADODETALLE_DEPARTAMENTO1");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Trasladodetalles)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TRASLADODETALLE_R02");

            entity.HasOne(d => d.SecuencialtrasladoNavigation).WithMany(p => p.Trasladodetalles)
                .HasForeignKey(d => d.Secuencialtraslado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TRASLADODETALLE_R01");
        });

        modelBuilder.Entity<Zona>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("ZONA", "FBS_ORGANIZACIONES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Siglas)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("SIGLAS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
