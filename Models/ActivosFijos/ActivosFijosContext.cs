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

    public virtual DbSet<Estadofisicoactivo> Estadofisicoactivos { get; set; }

    public virtual DbSet<EstructactfijcondCuentasorden> EstructactfijcondCuentasordens { get; set; }

    public virtual DbSet<Indicecorreccion> Indicecorreccions { get; set; }

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

    public virtual DbSet<Pdum> Pda { get; set; }

    public virtual DbSet<PersonaResponsable> PersonaResponsables { get; set; }

    public virtual DbSet<PuntodeventaDepartamento> PuntodeventaDepartamentos { get; set; }

    public virtual DbSet<Solicitudactivobaja> Solicitudactivobajas { get; set; }

    public virtual DbSet<SolicitudactivobajaCompcausal> SolicitudactivobajaCompcausals { get; set; }

    public virtual DbSet<Solicitudactivobajacambioest> Solicitudactivobajacambioests { get; set; }

    public virtual DbSet<Solicitudactivobajalote> Solicitudactivobajalotes { get; set; }

    public virtual DbSet<Tipoarea> Tipoareas { get; set; }

    public virtual DbSet<Traslado> Traslados { get; set; }

    public virtual DbSet<Trasladodetalle> Trasladodetalles { get; set; }

    public virtual DbSet<Zona> Zonas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
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
                .HasMaxLength(20)
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
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fechacliente)
                .HasColumnType("datetime")
                .HasColumnName("FECHACLIENTE");
            entity.Property(e => e.Idcontrol).HasColumnName("IDCONTROL");
            entity.Property(e => e.Secuencialactivo).HasColumnName("SECUENCIALACTIVO");

            entity.HasOne(d => d.IdcontrolNavigation).WithMany(p => p.Controldetalles)
                .HasForeignKey(d => d.Idcontrol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTROLDETALLE_CONTROL");

            entity.HasOne(d => d.SecuencialactivoNavigation).WithMany(p => p.Controldetalles)
                .HasForeignKey(d => d.Secuencialactivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTROLDETALLE_ACTIVO");
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
