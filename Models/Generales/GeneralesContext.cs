using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CorePilarh.Models.Generales;

public partial class GeneralesContext : DbContext
{
    public GeneralesContext()
    {
    }

    public GeneralesContext(DbContextOptions<GeneralesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividadeconomica> Actividadeconomicas { get; set; }

    public virtual DbSet<Actividadeconomicacnb> Actividadeconomicacnbs { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<BancoFormatoestadoctaban> BancoFormatoestadoctabans { get; set; }

    public virtual DbSet<Bancoempresa> Bancoempresas { get; set; }

    public virtual DbSet<Calendario> Calendarios { get; set; }

    public virtual DbSet<Calificacionriesgomicrofactoring> Calificacionriesgomicrofactorings { get; set; }

    public virtual DbSet<Campodireccion> Campodireccions { get; set; }

    public virtual DbSet<Campoparametro> Campoparametros { get; set; }

    public virtual DbSet<CampoparametroTexto> CampoparametroTextos { get; set; }

    public virtual DbSet<Campoparametrovalorlistum> Campoparametrovalorlista { get; set; }

    public virtual DbSet<Caracteristica> Caracteristicas { get; set; }

    public virtual DbSet<CaracteristicaBooleana> CaracteristicaBooleanas { get; set; }

    public virtual DbSet<CaracteristicaFecha> CaracteristicaFechas { get; set; }

    public virtual DbSet<CaracteristicaNumerica> CaracteristicaNumericas { get; set; }

    public virtual DbSet<CaracteristicaTexto> CaracteristicaTextos { get; set; }

    public virtual DbSet<Caracteristicalistamultiple> Caracteristicalistamultiples { get; set; }

    public virtual DbSet<Caracteristicalistum> Caracteristicalista { get; set; }

    public virtual DbSet<Caracteristicatipocaracterist> Caracteristicatipocaracterists { get; set; }

    public virtual DbSet<Codigopresupuestario> Codigopresupuestarios { get; set; }

    public virtual DbSet<CostoActividadeconomicaDivisionpolitica> CostoActividadeconomicaDivisionpoliticas { get; set; }

    public virtual DbSet<Detallepresupuestoglobal> Detallepresupuestoglobals { get; set; }

    public virtual DbSet<Diferenciatabla> Diferenciatablas { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<DivisionActiecontipoindustrium> DivisionActiecontipoindustria { get; set; }

    public virtual DbSet<DivisionCodigordep> DivisionCodigordeps { get; set; }

    public virtual DbSet<DivisionEnlazaactiecon> DivisionEnlazaactiecons { get; set; }

    public virtual DbSet<Divisionbooleana> Divisionbooleanas { get; set; }

    public virtual DbSet<Divisioncaracteristicalistum> Divisioncaracteristicalista { get; set; }

    public virtual DbSet<Divisionfecha> Divisionfechas { get; set; }

    public virtual DbSet<Divisionnumerica> Divisionnumericas { get; set; }

    public virtual DbSet<Divisionpolitica> Divisionpoliticas { get; set; }

    public virtual DbSet<Divisiontexto> Divisiontextos { get; set; }

    public virtual DbSet<Empofiperfiscalgenactacomi> Empofiperfiscalgenactacomis { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EmpresaClaveseguridad> EmpresaClaveseguridads { get; set; }

    public virtual DbSet<EmpresaDocumento> EmpresaDocumentos { get; set; }

    public virtual DbSet<EmpresaInformacioncontacto> EmpresaInformacioncontactos { get; set; }

    public virtual DbSet<EmpresaInformacionsri> EmpresaInformacionsris { get; set; }

    public virtual DbSet<EmpresaNumcertifireten> EmpresaNumcertifiretens { get; set; }

    public virtual DbSet<EmpresaParametrobusquedacli> EmpresaParametrobusquedaclis { get; set; }

    public virtual DbSet<EmpresaParametrodivisiongeo> EmpresaParametrodivisiongeos { get; set; }

    public virtual DbSet<EmpresaParametrolog> EmpresaParametrologs { get; set; }

    public virtual DbSet<EmpresaParametromensajerium> EmpresaParametromensajeria { get; set; }

    public virtual DbSet<EmpresaParametrooficonsoli> EmpresaParametrooficonsolis { get; set; }

    public virtual DbSet<EmpresaParametroplandecuenta> EmpresaParametroplandecuentas { get; set; }

    public virtual DbSet<EmpresaParametroporcentajeiva> EmpresaParametroporcentajeivas { get; set; }

    public virtual DbSet<EmpresaParametroreposentencium> EmpresaParametroreposentencia { get; set; }

    public virtual DbSet<EmpresaUsuariodocumento> EmpresaUsuariodocumentos { get; set; }

    public virtual DbSet<Empresaburocredito> Empresaburocreditos { get; set; }

    public virtual DbSet<Empresaimagenpersona> Empresaimagenpersonas { get; set; }

    public virtual DbSet<Empresatelefonica> Empresatelefonicas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Fondocnb> Fondocnbs { get; set; }

    public virtual DbSet<IdentificacionbancariaBanco> IdentificacionbancariaBancos { get; set; }

    public virtual DbSet<Impuestorentum> Impuestorenta { get; set; }

    public virtual DbSet<Institucionfinanciera> Institucionfinancieras { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<Mensajerium> Mensajeria { get; set; }

    public virtual DbSet<Monedum> Moneda { get; set; }

    public virtual DbSet<Niveldivision> Niveldivisions { get; set; }

    public virtual DbSet<Padredivision> Padredivisions { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Plantillahtml> Plantillahtmls { get; set; }

    public virtual DbSet<Productomicrofactoring> Productomicrofactorings { get; set; }

    public virtual DbSet<Semillaidentity> Semillaidentities { get; set; }

    public virtual DbSet<Serviciosinreplica> Serviciosinreplicas { get; set; }

    public virtual DbSet<Storeprocedure> Storeprocedures { get; set; }

    public virtual DbSet<Tipobanco> Tipobancos { get; set; }

    public virtual DbSet<Tipocaracteristica> Tipocaracteristicas { get; set; }

    public virtual DbSet<Tipocorreo> Tipocorreos { get; set; }

    public virtual DbSet<Tipodivision> Tipodivisions { get; set; }

    public virtual DbSet<TipodivisionEmpresa> TipodivisionEmpresas { get; set; }

    public virtual DbSet<Tipogarantiacnb> Tipogarantiacnbs { get; set; }

    public virtual DbSet<Tipoindustrium> Tipoindustria { get; set; }

    public virtual DbSet<Tipotelefono> Tipotelefonos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividadeconomica>(entity =>
        {
            entity.HasKey(e => e.Secuencialdivision).HasFillFactor(80);

            entity.ToTable("ACTIVIDADECONOMICA", "FBS_GENERALES");

            entity.Property(e => e.Secuencialdivision)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Apnfd).HasColumnName("APNFD");
            entity.Property(e => e.Esproductiva).HasColumnName("ESPRODUCTIVA");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithOne(p => p.Actividadeconomica)
                .HasForeignKey<Actividadeconomica>(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIVIDADECONOMICA_DIVISION");
        });

        modelBuilder.Entity<Actividadeconomicacnb>(entity =>
        {
            entity.HasKey(e => e.Secuencialdivision).HasFillFactor(80);

            entity.ToTable("ACTIVIDADECONOMICACNBS", "FBS_GENERALES");

            entity.Property(e => e.Secuencialdivision)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("BANCO_PK")
                .HasFillFactor(80);

            entity.ToTable("BANCO", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Aba)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("ABA");
            entity.Property(e => e.Chips)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CHIPS");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Codigotipobanco)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("CODIGOTIPOBANCO");
            entity.Property(e => e.Direccionbancobeneficiario)
                .HasMaxLength(500)
                .HasColumnName("DIRECCIONBANCOBENEFICIARIO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fed)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("FED");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Nombrebancobeneficiario)
                .HasMaxLength(100)
                .HasColumnName("NOMBREBANCOBENEFICIARIO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Swift)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("SWIFT");

            entity.HasOne(d => d.CodigotipobancoNavigation).WithMany(p => p.Bancos)
                .HasForeignKey(d => d.Codigotipobanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("BANCO_R01");
        });

        modelBuilder.Entity<BancoFormatoestadoctaban>(entity =>
        {
            entity.HasKey(e => e.Secuencialbanco)
                .HasName("BANCO_FORMATOESTADOCTABAN_PK")
                .HasFillFactor(80);

            entity.ToTable("BANCO_FORMATOESTADOCTABAN", "FBS_GENERALES");

            entity.Property(e => e.Secuencialbanco)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALBANCO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Separador)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("SEPARADOR");
            entity.Property(e => e.Ubicaciondocumentobancario).HasColumnName("UBICACIONDOCUMENTOBANCARIO");
            entity.Property(e => e.Ubicacionvalor).HasColumnName("UBICACIONVALOR");

            entity.HasOne(d => d.SecuencialbancoNavigation).WithOne(p => p.BancoFormatoestadoctaban)
                .HasForeignKey<BancoFormatoestadoctaban>(d => d.Secuencialbanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("BANCO_FORMATOESTADOCTABAN_R01");
        });

        modelBuilder.Entity<Bancoempresa>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("BANCOEMPRESA_PK")
                .HasFillFactor(80);

            entity.ToTable("BANCOEMPRESA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialbanco, e.Secuencialempresa }, "BANCOEMPRESA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialbanco).HasColumnName("SECUENCIALBANCO");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");

            entity.HasOne(d => d.SecuencialbancoNavigation).WithMany(p => p.Bancoempresas)
                .HasForeignKey(d => d.Secuencialbanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("BANCOEMPRESA_R01");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithMany(p => p.Bancoempresas)
                .HasForeignKey(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("BANCOEMPRESA_R02");
        });

        modelBuilder.Entity<Calendario>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("CALENDARIO_PK")
                .HasFillFactor(80);

            entity.ToTable("CALENDARIO", "FBS_GENERALES", tb => tb.HasTrigger("alerta_fincierre"));

            entity.HasIndex(e => e.Secuencialempresa, "CALENDARIO_I01").HasFillFactor(80);

            entity.HasIndex(e => new { e.Secuencialempresa, e.Fechasistema }, "CALENDARIO_IX")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.Fechasistema, e.Estacerrado, e.Esferiado }, "IX_CALENDARIO_FECHA_CERRADO_FERIADO");

            entity.HasIndex(e => new { e.Secuencialempresa, e.Estacerrado }, "IX_CALENDARIO_SECUENCIALEMPRESA_ESTACERRADO").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Esdepago)
                .HasDefaultValue(true)
                .HasColumnName("ESDEPAGO");
            entity.Property(e => e.Esferiado).HasColumnName("ESFERIADO");
            entity.Property(e => e.Eshabil).HasColumnName("ESHABIL");
            entity.Property(e => e.Estacerrado).HasColumnName("ESTACERRADO");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithMany(p => p.Calendarios)
                .HasForeignKey(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CALENDARIO_R01");
        });

        modelBuilder.Entity<Calificacionriesgomicrofactoring>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("CALIFICACIONRIESGOMICROFACTORING", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithMany(p => p.Calificacionriesgomicrofactorings)
                .HasForeignKey(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CALIFICACIONRIESGOMICROFACTORING_EMPRESA");
        });

        modelBuilder.Entity<Campodireccion>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("CAMPODIRECCION", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Masusado).HasColumnName("MASUSADO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Posiblenombre).HasColumnName("POSIBLENOMBRE");
        });

        modelBuilder.Entity<Campoparametro>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("CAMPOPARAMETRO_PK")
                .HasFillFactor(80);

            entity.ToTable("CAMPOPARAMETRO", "FBS_GENERALES");

            entity.Property(e => e.Secuencial)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIAL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Estexto).HasColumnName("ESTEXTO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<CampoparametroTexto>(entity =>
        {
            entity.HasKey(e => e.Secuencialcampoparametro)
                .HasName("CAMPOPARAMETRO_TEXTO_PK")
                .HasFillFactor(80);

            entity.ToTable("CAMPOPARAMETRO_TEXTO", "FBS_GENERALES");

            entity.Property(e => e.Secuencialcampoparametro)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALCAMPOPARAMETRO");
            entity.Property(e => e.Codigotipodato)
                .HasMaxLength(100)
                .HasColumnName("CODIGOTIPODATO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Maximalongitud).HasColumnName("MAXIMALONGITUD");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialcampoparametroNavigation).WithOne(p => p.CampoparametroTexto)
                .HasForeignKey<CampoparametroTexto>(d => d.Secuencialcampoparametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CAMPOPARAMETRO_TEXTO_R01");
        });

        modelBuilder.Entity<Campoparametrovalorlistum>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("CAMPOPARAMETROVALORLISTA_PK")
                .HasFillFactor(80);

            entity.ToTable("CAMPOPARAMETROVALORLISTA", "FBS_GENERALES");

            entity.Property(e => e.Secuencial)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialcampoparametro).HasColumnName("SECUENCIALCAMPOPARAMETRO");

            entity.HasOne(d => d.SecuencialcampoparametroNavigation).WithMany(p => p.Campoparametrovalorlista)
                .HasForeignKey(d => d.Secuencialcampoparametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CAMPOPARAMETROVALORLISTA_R01");
        });

        modelBuilder.Entity<Caracteristica>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("CARACTERISTICA", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Esobligatorio).HasColumnName("ESOBLIGATORIO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(1000)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
        });

        modelBuilder.Entity<CaracteristicaBooleana>(entity =>
        {
            entity.HasKey(e => e.Codigocaracteristica)
                .HasName("PK_CARACTERISTICABOLEANA")
                .HasFillFactor(80);

            entity.ToTable("CARACTERISTICA_BOOLEANA", "FBS_GENERALES");

            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithOne(p => p.CaracteristicaBooleana)
                .HasForeignKey<CaracteristicaBooleana>(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARACTERISTICABOLEANA_CARACTERISTICA1");
        });

        modelBuilder.Entity<CaracteristicaFecha>(entity =>
        {
            entity.HasKey(e => e.Codigocaracteristica)
                .HasName("PK_CARACTERISTICAFECHA")
                .HasFillFactor(80);

            entity.ToTable("CARACTERISTICA_FECHA", "FBS_GENERALES");

            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fechadefecto)
                .HasColumnType("datetime")
                .HasColumnName("FECHADEFECTO");
            entity.Property(e => e.Fechafin)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.Fechainicio)
                .HasColumnType("datetime")
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.Formatofecha)
                .HasMaxLength(20)
                .HasColumnName("FORMATOFECHA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithOne(p => p.CaracteristicaFecha)
                .HasForeignKey<CaracteristicaFecha>(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARACTERISTICAFECHA_CARACTERISTICA1");
        });

        modelBuilder.Entity<CaracteristicaNumerica>(entity =>
        {
            entity.HasKey(e => e.Codigocaracteristica)
                .HasName("PK_CARACTERISTICADECIMAL")
                .HasFillFactor(80);

            entity.ToTable("CARACTERISTICA_NUMERICA", "FBS_GENERALES");

            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Precisiondecimal).HasColumnName("PRECISIONDECIMAL");
            entity.Property(e => e.Precisionentero).HasColumnName("PRECISIONENTERO");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithOne(p => p.CaracteristicaNumerica)
                .HasForeignKey<CaracteristicaNumerica>(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARACTERISTICANUMERICA_CARACTERISTICA");
        });

        modelBuilder.Entity<CaracteristicaTexto>(entity =>
        {
            entity.HasKey(e => e.Codigocaracteristica)
                .HasName("PK_CARACTERISTICATEXTO_1")
                .HasFillFactor(80);

            entity.ToTable("CARACTERISTICA_TEXTO", "FBS_GENERALES");

            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Mayusculas).HasColumnName("MAYUSCULAS");
            entity.Property(e => e.Numerocaracteres).HasColumnName("NUMEROCARACTERES");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Regularexpression)
                .HasMaxLength(200)
                .HasColumnName("REGULAREXPRESSION");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithOne(p => p.CaracteristicaTexto)
                .HasForeignKey<CaracteristicaTexto>(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARACTERISTICATEXTO_CARACTERISTICA1");
        });

        modelBuilder.Entity<Caracteristicalistamultiple>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("CARACTERISTICALISTAMULTIPLE", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PESO");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithMany(p => p.Caracteristicalistamultiples)
                .HasForeignKey(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARACTERISTICALISTAMULTIPLE_CARACTERISTICA");
        });

        modelBuilder.Entity<Caracteristicalistum>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK_CARACTERISTICA_ITEMLISTA")
                .HasFillFactor(80);

            entity.ToTable("CARACTERISTICALISTA", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Orden).HasColumnName("ORDEN");
            entity.Property(e => e.Peso)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PESO");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithMany(p => p.Caracteristicalista)
                .HasForeignKey(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARACTERISTICA_ITEMLISTA_CARACTERISTICA");
        });

        modelBuilder.Entity<Caracteristicatipocaracterist>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("CARACTERISTICATIPOCARACTERIST", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Codigocaracteristica, e.Codigotipocaracteristica }, "IX_CARACTERISTICATIPOCARACTERIST")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Codigotipocaracteristica)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODIGOTIPOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithMany(p => p.Caracteristicatipocaracterists)
                .HasForeignKey(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARACTERISTICATIPOCARACTERIST_CARACTERISTICA");

            entity.HasOne(d => d.CodigotipocaracteristicaNavigation).WithMany(p => p.Caracteristicatipocaracterists)
                .HasForeignKey(d => d.Codigotipocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CARACTERISTICATIPOCARACTERIST_TIPOCARACTERISTICA");
        });

        modelBuilder.Entity<Codigopresupuestario>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("CODIGOPRESUPUESTARIO", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<CostoActividadeconomicaDivisionpolitica>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK_COSTO_ACTIVIDADECONOMICA_UBICACIONGEOGRAFICA")
                .HasFillFactor(80);

            entity.ToTable("COSTO_ACTIVIDADECONOMICA_DIVISIONPOLITICA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialactividadeconomica, e.Secuencialdivisionpolitica, e.Estaactivo }, "IX_COSTO_ACTIVIDADECONOMICA_DIVISIONPOLITICA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialactividadeconomica).HasColumnName("SECUENCIALACTIVIDADECONOMICA");
            entity.Property(e => e.Secuencialdivisionpolitica).HasColumnName("SECUENCIALDIVISIONPOLITICA");

            entity.HasOne(d => d.SecuencialactividadeconomicaNavigation).WithMany(p => p.CostoActividadeconomicaDivisionpoliticas)
                .HasForeignKey(d => d.Secuencialactividadeconomica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COSTO_ACTIVIDADECONOMICA_DIVISIONPOLITICA_ACTIVIDADECONOMICA");

            entity.HasOne(d => d.SecuencialdivisionpoliticaNavigation).WithMany(p => p.CostoActividadeconomicaDivisionpoliticas)
                .HasForeignKey(d => d.Secuencialdivisionpolitica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COSTO_ACTIVIDADECONOMICA_DIVISIONPOLITICA_DIVISIONPOLITICA");
        });

        modelBuilder.Entity<Detallepresupuestoglobal>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("DETALLEPRESUPUESTOGLOBAL", "FBS_GENERALES");

            entity.HasIndex(e => e.Secuencial, "IX_DETALLEPRESUPUESTOGLOBAL").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigopresupuestario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGOPRESUPUESTARIO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Secuencialdivision).HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VALOR");

            entity.HasOne(d => d.CodigopresupuestarioNavigation).WithMany(p => p.Detallepresupuestoglobals)
                .HasForeignKey(d => d.Codigopresupuestario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DETALLEPRESUPUESTOGLOBAL_CODIGOPRESUPUESTARIO");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithMany(p => p.Detallepresupuestoglobals)
                .HasForeignKey(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DETALLEPRESUPUESTOGLOBAL_DIVISION");
        });

        modelBuilder.Entity<Diferenciatabla>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("DIFERENCIATABLA", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Registrodiferente).HasColumnName("REGISTRODIFERENTE");
            entity.Property(e => e.Tabla)
                .HasMaxLength(500)
                .HasColumnName("TABLA");
            entity.Property(e => e.Tiempo).HasColumnName("TIEMPO");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("DIVISION_PK")
                .HasFillFactor(80);

            entity.ToTable("DIVISION", "FBS_GENERALES");

            entity.HasIndex(e => e.Secuencialnivel, "DIVISION_I01").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigo)
                .HasMaxLength(40)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(800)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialnivel).HasColumnName("SECUENCIALNIVEL");

            entity.HasOne(d => d.SecuencialnivelNavigation).WithMany(p => p.Divisions)
                .HasForeignKey(d => d.Secuencialnivel)
                .HasConstraintName("DIVISION_R01");
        });

        modelBuilder.Entity<DivisionActiecontipoindustrium>(entity =>
        {
            entity.HasKey(e => e.Secuencialdivision).HasFillFactor(80);

            entity.ToTable("DIVISION_ACTIECONTIPOINDUSTRIA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialdivision, e.Codigotipoindustria }, "IX_DIVISION_ACTIECONTIPOINDUSTRIA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencialdivision)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Codigotipoindustria)
                .HasMaxLength(10)
                .HasColumnName("CODIGOTIPOINDUSTRIA");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigotipoindustriaNavigation).WithMany(p => p.DivisionActiecontipoindustria)
                .HasForeignKey(d => d.Codigotipoindustria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISION_ACTIECONTIPOINDUSTRIA_TIPOINDUSTRIA");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithOne(p => p.DivisionActiecontipoindustrium)
                .HasForeignKey<DivisionActiecontipoindustrium>(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISION_ACTIECONTIPOINDUSTRIA_DIVISION");
        });

        modelBuilder.Entity<DivisionCodigordep>(entity =>
        {
            entity.HasKey(e => e.Secuencialdivision).HasFillFactor(80);

            entity.ToTable("DIVISION_CODIGORDEP", "FBS_GENERALES");

            entity.Property(e => e.Secuencialdivision)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Codigordep)
                .HasMaxLength(20)
                .HasColumnName("CODIGORDEP");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithOne(p => p.DivisionCodigordep)
                .HasForeignKey<DivisionCodigordep>(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISION_CODIGORDEP_DIVISION");
        });

        modelBuilder.Entity<DivisionEnlazaactiecon>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("DIVISION_ENLAZAACTIECON", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivisionactiecon).HasColumnName("SECUENCIALDIVISIONACTIECON");
            entity.Property(e => e.Secuencialdivisionactieconcnbs).HasColumnName("SECUENCIALDIVISIONACTIECONCNBS");

            entity.HasOne(d => d.SecuencialdivisionactieconNavigation).WithMany(p => p.DivisionEnlazaactieconSecuencialdivisionactieconNavigations)
                .HasForeignKey(d => d.Secuencialdivisionactiecon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISION_ENLAZAACTIECON_DIVISION");

            entity.HasOne(d => d.SecuencialdivisionactieconcnbsNavigation).WithMany(p => p.DivisionEnlazaactieconSecuencialdivisionactieconcnbsNavigations)
                .HasForeignKey(d => d.Secuencialdivisionactieconcnbs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISION_ENLAZAACTIECON_DIVISION1");
        });

        modelBuilder.Entity<Divisionbooleana>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("DIVISIONBOOLEANA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialdivision, e.Codigocaracteristica }, "IX_DIVISIONBOOLEANA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivision).HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Valor).HasColumnName("VALOR");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithMany(p => p.Divisionbooleanas)
                .HasForeignKey(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONBOOLEANA_CARACTERISTICA");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithMany(p => p.Divisionbooleanas)
                .HasForeignKey(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONBOOLEANA_DIVISION");
        });

        modelBuilder.Entity<Divisioncaracteristicalistum>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK_DIVISIONLISTA")
                .HasFillFactor(80);

            entity.ToTable("DIVISIONCARACTERISTICALISTA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialdivision, e.Secuencialcaracteristicalista }, "IX_DIVISIONCARACTERISTICALISTA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialcaracteristicalista).HasColumnName("SECUENCIALCARACTERISTICALISTA");
            entity.Property(e => e.Secuencialdivision).HasColumnName("SECUENCIALDIVISION");

            entity.HasOne(d => d.SecuencialcaracteristicalistaNavigation).WithMany(p => p.Divisioncaracteristicalista)
                .HasForeignKey(d => d.Secuencialcaracteristicalista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONLISTA_CARACTERISTICALISTA");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithMany(p => p.Divisioncaracteristicalista)
                .HasForeignKey(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONLISTA_DIVISION");
        });

        modelBuilder.Entity<Divisionfecha>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("DIVISIONFECHA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialdivision, e.Codigocaracteristica }, "IX_DIVISIONFECHA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivision).HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Valor)
                .HasColumnType("datetime")
                .HasColumnName("VALOR");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithMany(p => p.Divisionfechas)
                .HasForeignKey(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONFECHA_CARACTERISTICA");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithMany(p => p.Divisionfechas)
                .HasForeignKey(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONFECHA_DIVISION");
        });

        modelBuilder.Entity<Divisionnumerica>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("DIVISIONNUMERICA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialdivision, e.Codigocaracteristica }, "IX_DIVISIONNUMERICA")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivision).HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Valordecimal).HasColumnName("VALORDECIMAL");
            entity.Property(e => e.Valorentero).HasColumnName("VALORENTERO");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithMany(p => p.Divisionnumericas)
                .HasForeignKey(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONNUMERICA_CARACTERISTICA");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithMany(p => p.Divisionnumericas)
                .HasForeignKey(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONNUMERICA_DIVISION");
        });

        modelBuilder.Entity<Divisionpolitica>(entity =>
        {
            entity.HasKey(e => e.Secuencialdivision).HasFillFactor(80);

            entity.ToTable("DIVISIONPOLITICA", "FBS_GENERALES");

            entity.Property(e => e.Secuencialdivision)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Esurbana).HasColumnName("ESURBANA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithOne(p => p.Divisionpolitica)
                .HasForeignKey<Divisionpolitica>(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONPOLITICA_DIVISION");
        });

        modelBuilder.Entity<Divisiontexto>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("DIVISIONTEXTO", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialdivision, e.Codigocaracteristica }, "IX_DIVISIONTEXTO")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigocaracteristica)
                .HasMaxLength(10)
                .HasColumnName("CODIGOCARACTERISTICA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivision).HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Valor)
                .HasMaxLength(500)
                .HasColumnName("VALOR");

            entity.HasOne(d => d.CodigocaracteristicaNavigation).WithMany(p => p.Divisiontextos)
                .HasForeignKey(d => d.Codigocaracteristica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONTEXTO_CARACTERISTICA");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithMany(p => p.Divisiontextos)
                .HasForeignKey(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIVISIONTEXTO_DIVISION");
        });

        modelBuilder.Entity<Empofiperfiscalgenactacomi>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK_EMPRESAPERFISCALGENACTACOMI")
                .HasFillFactor(80);

            entity.ToTable("EMPOFIPERFISCALGENACTACOMI", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialempresa, e.Secuencialoficina }, "IX_EMPOFIPERFISCALGENACTACOMI").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Periodofiscal).HasColumnName("PERIODOFISCAL");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");
            entity.Property(e => e.Ultimosecuencialactacomite).HasColumnName("ULTIMOSECUENCIALACTACOMITE");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithMany(p => p.Empofiperfiscalgenactacomis)
                .HasForeignKey(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPOFIPERFISCALGENACTACOMI_EMPRESA");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("EMPRESA_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA", "FBS_GENERALES");

            entity.HasIndex(e => e.Nombre, "EMPRESA_IX")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigooficinacontrol)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("CODIGOOFICINACONTROL");
            entity.Property(e => e.Codigopais)
                .HasMaxLength(20)
                .HasColumnName("CODIGOPAIS");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialmonedaoficial).HasColumnName("SECUENCIALMONEDAOFICIAL");
            entity.Property(e => e.Siglas)
                .HasMaxLength(100)
                .HasColumnName("SIGLAS");

            entity.HasOne(d => d.CodigopaisNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.Codigopais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C0031791");

            entity.HasOne(d => d.SecuencialmonedaoficialNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.Secuencialmonedaoficial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESA_R01");
        });

        modelBuilder.Entity<EmpresaClaveseguridad>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("EMPRESA_CLAVESEGURIDAD", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Clave)
                .HasMaxLength(500)
                .HasColumnName("CLAVE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<EmpresaDocumento>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("EMPRESA_DOCUMENTO_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_DOCUMENTO", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Ultimonumerodocumentomov).HasColumnName("ULTIMONUMERODOCUMENTOMOV");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaDocumento)
                .HasForeignKey<EmpresaDocumento>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESA_DOCUMENTO_R01");
        });

        modelBuilder.Entity<EmpresaInformacioncontacto>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("PK_INFORMACIONCONTACTO")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_INFORMACIONCONTACTO", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombrecompleto)
                .HasMaxLength(100)
                .HasColumnName("NOMBRECOMPLETO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaInformacioncontacto)
                .HasForeignKey<EmpresaInformacioncontacto>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_INFORMACIONCONTACTO_EMPRESA");
        });

        modelBuilder.Entity<EmpresaInformacionsri>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("EMPRESA_INFORMACIONSRI_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_INFORMACIONSRI", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Direccionmatriz)
                .HasMaxLength(100)
                .HasColumnName("DIRECCIONMATRIZ");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Idrepresentantelegal)
                .HasMaxLength(40)
                .HasColumnName("IDREPRESENTANTELEGAL");
            entity.Property(e => e.Numeroruc)
                .HasMaxLength(40)
                .HasColumnName("NUMERORUC");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(100)
                .HasColumnName("RAZONSOCIAL");
            entity.Property(e => e.Ruccontador)
                .HasMaxLength(40)
                .HasColumnName("RUCCONTADOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(40)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Tipoidrepresentantelegal)
                .HasMaxLength(10)
                .HasColumnName("TIPOIDREPRESENTANTELEGAL");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaInformacionsri)
                .HasForeignKey<EmpresaInformacionsri>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESA_INFORMACIONSRI_R01");
        });

        modelBuilder.Entity<EmpresaNumcertifireten>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("PK_EMPRESA_NUMEROCERTIFICADORETENCION")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_NUMCERTIFIRETEN", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Numerocertificado).HasColumnName("NUMEROCERTIFICADO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaNumcertifireten)
                .HasForeignKey<EmpresaNumcertifireten>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_NUMEROCERTIFICADORETENCION_EMPRESA");
        });

        modelBuilder.Entity<EmpresaParametrobusquedacli>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("EMPRESA_PARAMETROBUSQUEDACL_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETROBUSQUEDACLI", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Buscapornumero).HasColumnName("BUSCAPORNUMERO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaParametrobusquedacli)
                .HasForeignKey<EmpresaParametrobusquedacli>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESA_PARAMETROBUSQUEDAC_R01");
        });

        modelBuilder.Entity<EmpresaParametrodivisiongeo>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("EMPRESA_PARAMETRODIVISIONGE_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETRODIVISIONGEO", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialnivelrequeridonacimi).HasColumnName("SECUENCIALNIVELREQUERIDONACIMI");
            entity.Property(e => e.Secuencialnivelrequeridoreside).HasColumnName("SECUENCIALNIVELREQUERIDORESIDE");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaParametrodivisiongeo)
                .HasForeignKey<EmpresaParametrodivisiongeo>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESA_PARAMETRODIVISIONG_R01");

            entity.HasOne(d => d.SecuencialnivelrequeridonacimiNavigation).WithMany(p => p.EmpresaParametrodivisiongeoSecuencialnivelrequeridonacimiNavigations)
                .HasForeignKey(d => d.Secuencialnivelrequeridonacimi)
                .HasConstraintName("EMPRESA_PARAMETRODIVISIONG_R02");

            entity.HasOne(d => d.SecuencialnivelrequeridoresideNavigation).WithMany(p => p.EmpresaParametrodivisiongeoSecuencialnivelrequeridoresideNavigations)
                .HasForeignKey(d => d.Secuencialnivelrequeridoreside)
                .HasConstraintName("EMPRESA_PARAMETRODIVISIONG_R03");
        });

        modelBuilder.Entity<EmpresaParametrolog>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("EMPRESA_PARAMETROLOG_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETROLOG", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.AlmacenalogaccCamclaprxinglot).HasColumnName("ALMACENALOGACC_CAMCLAPRXINGLOT");
            entity.Property(e => e.Almacenalogaccesousuario).HasColumnName("ALMACENALOGACCESOUSUARIO");
            entity.Property(e => e.AlmacenalogaccionCamclalot).HasColumnName("ALMACENALOGACCION_CAMCLALOT");
            entity.Property(e => e.AlmacenalogaccionCamferiado).HasColumnName("ALMACENALOGACCION_CAMFERIADO");
            entity.Property(e => e.AlmacenalogclaveIndividual).HasColumnName("ALMACENALOGCLAVE_INDIVIDUAL");
            entity.Property(e => e.AlmacenalogclaveLote).HasColumnName("ALMACENALOGCLAVE_LOTE");
            entity.Property(e => e.Almacenalogsalidausuario).HasColumnName("ALMACENALOGSALIDAUSUARIO");
            entity.Property(e => e.Almacenatiemporespuesta).HasColumnName("ALMACENATIEMPORESPUESTA");
            entity.Property(e => e.Despliegatiemporespuesta).HasColumnName("DESPLIEGATIEMPORESPUESTA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaParametrolog)
                .HasForeignKey<EmpresaParametrolog>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESA_PARAMETROLOG_R01");
        });

        modelBuilder.Entity<EmpresaParametromensajerium>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("EMPRESA_PARAMETROMENSAJERIA_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETROMENSAJERIA", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Enviamailexternocambioclaveind).HasColumnName("ENVIAMAILEXTERNOCAMBIOCLAVEIND");
            entity.Property(e => e.Enviamailexternocambioclavelot).HasColumnName("ENVIAMAILEXTERNOCAMBIOCLAVELOT");
            entity.Property(e => e.Enviamailinternocambioclaveind).HasColumnName("ENVIAMAILINTERNOCAMBIOCLAVEIND");
            entity.Property(e => e.Enviamailinternocambioclavelot).HasColumnName("ENVIAMAILINTERNOCAMBIOCLAVELOT");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaParametromensajerium)
                .HasForeignKey<EmpresaParametromensajerium>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESA_PARAMETROMENSAJERIAR01");
        });

        modelBuilder.Entity<EmpresaParametrooficonsoli>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa).HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETROOFICONSOLI", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Esprincipal).HasColumnName("ESPRINCIPAL");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialoficinaconsolidado).HasColumnName("SECUENCIALOFICINACONSOLIDADO");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaParametrooficonsoli)
                .HasForeignKey<EmpresaParametrooficonsoli>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_PARAMETROOFICONSOLI_EMPRESA");

            entity.HasOne(d => d.SecuencialoficinaconsolidadoNavigation).WithMany(p => p.EmpresaParametrooficonsolis)
                .HasForeignKey(d => d.Secuencialoficinaconsolidado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_PARAMETROOFICONSOLI_DIVISION");
        });

        modelBuilder.Entity<EmpresaParametroplandecuenta>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa).HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETROPLANDECUENTAS", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialtipodivisionplanctas).HasColumnName("SECUENCIALTIPODIVISIONPLANCTAS");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaParametroplandecuenta)
                .HasForeignKey<EmpresaParametroplandecuenta>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_PARAMETROPLANDECUENTAS_EMPRESA");

            entity.HasOne(d => d.SecuencialtipodivisionplanctasNavigation).WithMany(p => p.EmpresaParametroplandecuenta)
                .HasForeignKey(d => d.Secuencialtipodivisionplanctas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_PARAMETROPLANDECUENTAS_TIPODIVISION");
        });

        modelBuilder.Entity<EmpresaParametroporcentajeiva>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa).HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETROPORCENTAJEIVA", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Codigousuarioregistra)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIOREGISTRA");
            entity.Property(e => e.Fechamaquinaingreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINAINGRESO");
            entity.Property(e => e.Fechasistemaingreso)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMAINGRESO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PORCENTAJE");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaParametroporcentajeiva)
                .HasForeignKey<EmpresaParametroporcentajeiva>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_PARAMETROPORCENTAJEIVA_EMPRESA");
        });

        modelBuilder.Entity<EmpresaParametroreposentencium>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa).HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETROREPOSENTENCIA", "FBS_GENERALES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Passwordftpcentral)
                .HasMaxLength(200)
                .HasColumnName("PASSWORDFTPCENTRAL");
            entity.Property(e => e.Pathdirectorioofdescon)
                .HasMaxLength(50)
                .HasColumnName("PATHDIRECTORIOOFDESCON");
            entity.Property(e => e.Pathservidorftpcentral)
                .HasMaxLength(50)
                .HasColumnName("PATHSERVIDORFTPCENTRAL");
            entity.Property(e => e.Urldirectorioofdescon)
                .HasMaxLength(50)
                .HasColumnName("URLDIRECTORIOOFDESCON");
            entity.Property(e => e.Urlservidorftpcentral)
                .HasMaxLength(20)
                .HasColumnName("URLSERVIDORFTPCENTRAL");
            entity.Property(e => e.Userftpcentral)
                .HasMaxLength(20)
                .HasColumnName("USERFTPCENTRAL");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithOne(p => p.EmpresaParametroreposentencium)
                .HasForeignKey<EmpresaParametroreposentencium>(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_PARAMETROREPOSENTENCIA_EMPRESA");
        });

        modelBuilder.Entity<EmpresaUsuariodocumento>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("EMPRESA_USUARIODOCUMENTO", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Codigousuario, e.Secuencialempresa }, "IX_EMPRESA_USUARIODOCUMENTO")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Codigousuario, "IX_EMPRESA_USUARIODOCUMENTO_1").HasFillFactor(80);

            entity.HasIndex(e => e.Secuencialempresa, "IX_EMPRESA_USUARIODOCUMENTO_2").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Ultimonumerodocumentomovimiento).HasColumnName("ULTIMONUMERODOCUMENTOMOVIMIENTO");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithMany(p => p.EmpresaUsuariodocumentos)
                .HasForeignKey(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMPRESA_USUARIODOCUMENTO_EMPRESA");
        });

        modelBuilder.Entity<Empresaburocredito>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("EMPRESABUROCREDITO", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Claveservicio)
                .HasMaxLength(50)
                .HasColumnName("CLAVESERVICIO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Metodoservicio)
                .HasMaxLength(100)
                .HasColumnName("METODOSERVICIO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Pais)
                .HasMaxLength(10)
                .HasColumnName("PAIS");
            entity.Property(e => e.Secuencialreporte).HasColumnName("SECUENCIALREPORTE");
            entity.Property(e => e.Secuencialreportecredito).HasColumnName("SECUENCIALREPORTECREDITO");
            entity.Property(e => e.Urlservicio)
                .HasMaxLength(200)
                .HasColumnName("URLSERVICIO");
            entity.Property(e => e.Usuarioservicio)
                .HasMaxLength(50)
                .HasColumnName("USUARIOSERVICIO");
        });

        modelBuilder.Entity<Empresaimagenpersona>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("EMPRESAIMAGENPERSONA_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESAIMAGENPERSONA", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Carpeta)
                .HasMaxLength(500)
                .HasColumnName("CARPETA");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .HasColumnName("EXTENSION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithMany(p => p.Empresaimagenpersonas)
                .HasForeignKey(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESAIMAGENPERSONA_R01");
        });

        modelBuilder.Entity<Empresatelefonica>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("EMPRESATELEFONICA_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESATELEFONICA", "FBS_GENERALES");

            entity.HasIndex(e => e.Codigopais, "EMPRESATELEFONICA_I01").HasFillFactor(80);

            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Codigopais)
                .HasMaxLength(20)
                .HasColumnName("CODIGOPAIS");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigopaisNavigation).WithMany(p => p.Empresatelefonicas)
                .HasForeignKey(d => d.Codigopais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMPRESATELEFONICA_R01");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("ESTADO", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Fondocnb>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("FONDOCNBS", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<IdentificacionbancariaBanco>(entity =>
        {
            entity.HasKey(e => e.Secuencialbanco).HasFillFactor(80);

            entity.ToTable("IDENTIFICACIONBANCARIA_BANCO", "FBS_GENERALES");

            entity.Property(e => e.Secuencialbanco)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALBANCO");
            entity.Property(e => e.Aba)
                .HasMaxLength(20)
                .HasColumnName("ABA");
            entity.Property(e => e.Bic)
                .HasMaxLength(20)
                .HasColumnName("BIC");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Swift)
                .HasMaxLength(20)
                .HasColumnName("SWIFT");

            entity.HasOne(d => d.SecuencialbancoNavigation).WithOne(p => p.IdentificacionbancariaBanco)
                .HasForeignKey<IdentificacionbancariaBanco>(d => d.Secuencialbanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IDENTIFICACIONBANCARIA_BANCO_BANCO");
        });

        modelBuilder.Entity<Impuestorentum>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("IMPUESTORENTA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Fraccionbasica, e.Fraccionexcedente, e.Periodofiscal, e.Estaactivo }, "IX_IMPUESTORENTA").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fraccionbasica)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FRACCIONBASICA");
            entity.Property(e => e.Fraccionexcedente)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FRACCIONEXCEDENTE");
            entity.Property(e => e.Impuestofraccionbasica)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMPUESTOFRACCIONBASICA");
            entity.Property(e => e.Impuestofraccionexcedente)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMPUESTOFRACCIONEXCEDENTE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Periodofiscal).HasColumnName("PERIODOFISCAL");
        });

        modelBuilder.Entity<Institucionfinanciera>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("INSTITUCIONFINANCIERA", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(50)
                .HasColumnName("ABREVIATURA");
            entity.Property(e => e.Esregulada).HasColumnName("ESREGULADA");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("MENSAJE", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Lenguaje)
                .HasMaxLength(20)
                .HasColumnName("LENGUAJE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<Mensajerium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("MENSAJERIA", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Esautomatico).HasColumnName("ESAUTOMATICO");
            entity.Property(e => e.IdSp).HasColumnName("ID_SP");
            entity.Property(e => e.NombreSp)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE_SP");
            entity.Property(e => e.Plantilla)
                .HasMaxLength(100)
                .HasColumnName("PLANTILLA");
        });

        modelBuilder.Entity<Monedum>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("MONEDA_PK")
                .HasFillFactor(80);

            entity.ToTable("MONEDA", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigopais)
                .HasMaxLength(20)
                .HasColumnName("CODIGOPAIS");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Simbolo)
                .HasMaxLength(10)
                .HasColumnName("SIMBOLO");

            entity.HasOne(d => d.CodigopaisNavigation).WithMany(p => p.Moneda)
                .HasForeignKey(d => d.Codigopais)
                .HasConstraintName("FK_MONEDA_PAIS");
        });

        modelBuilder.Entity<Niveldivision>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("NIVELDIVISION_PK")
                .HasFillFactor(80);

            entity.ToTable("NIVELDIVISION", "FBS_GENERALES");

            entity.HasIndex(e => e.Secuencialtipodivision, "NIVELDIVISION_I01").HasFillFactor(80);

            entity.HasIndex(e => new { e.Nivel, e.Secuencialtipodivision }, "NonClusteredIndex-20130410-215704")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialtipodivision).HasColumnName("SECUENCIALTIPODIVISION");

            entity.HasOne(d => d.SecuencialtipodivisionNavigation).WithMany(p => p.Niveldivisions)
                .HasForeignKey(d => d.Secuencialtipodivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("NIVELDIVISION_R01");
        });

        modelBuilder.Entity<Padredivision>(entity =>
        {
            entity.HasKey(e => e.Secuencialdivision).HasFillFactor(80);

            entity.ToTable("PADREDIVISION", "FBS_GENERALES");

            entity.Property(e => e.Secuencialdivision)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALDIVISION");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialdivisionpadre).HasColumnName("SECUENCIALDIVISIONPADRE");

            entity.HasOne(d => d.SecuencialdivisionNavigation).WithOne(p => p.PadredivisionSecuencialdivisionNavigation)
                .HasForeignKey<Padredivision>(d => d.Secuencialdivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PADREDIVISION_DIVISION");

            entity.HasOne(d => d.SecuencialdivisionpadreNavigation).WithMany(p => p.PadredivisionSecuencialdivisionpadreNavigations)
                .HasForeignKey(d => d.Secuencialdivisionpadre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PADREDIVISION_DIVISION1");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PAIS_PK")
                .HasFillFactor(80);

            entity.ToTable("PAIS", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .HasColumnName("NACIONALIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialtipodivisionpolitica).HasColumnName("SECUENCIALTIPODIVISIONPOLITICA");

            entity.HasOne(d => d.SecuencialtipodivisionpoliticaNavigation).WithMany(p => p.Pais)
                .HasForeignKey(d => d.Secuencialtipodivisionpolitica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PAIS_R01");
        });

        modelBuilder.Entity<Plantillahtml>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PLANTILLAHTML", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Plantilla).HasColumnName("PLANTILLA");
        });

        modelBuilder.Entity<Productomicrofactoring>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("PRODUCTOMICROFACTORING", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(500)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Semillaidentity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SEMILLAIDENTITY", "FBS_GENERALES");

            entity.Property(e => e.Esquema)
                .HasMaxLength(50)
                .HasColumnName("ESQUEMA");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Reestableceidentity)
                .HasMaxLength(500)
                .HasColumnName("REESTABLECEIDENTITY");
            entity.Property(e => e.Semilla).HasColumnName("SEMILLA");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .HasColumnName("TABLA");
        });

        modelBuilder.Entity<Serviciosinreplica>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("SERVICIOSINREPLICA", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(500)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Storeprocedure>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("STOREPROCEDURE", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Sentenciasql)
                .HasMaxLength(500)
                .HasColumnName("SENTENCIASQL");
        });

        modelBuilder.Entity<Tipobanco>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("TIPOBANCO_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOBANCO", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipocaracteristica>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("TIPOCARACTERISTICA", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipocorreo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("TIPOCORREO", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Esprincipal).HasColumnName("ESPRINCIPAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipodivision>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TIPODIVISION_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPODIVISION", "FBS_GENERALES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<TipodivisionEmpresa>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("TIPODIVISION_EMPRESA_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPODIVISION_EMPRESA", "FBS_GENERALES");

            entity.HasIndex(e => new { e.Secuencialtipodivision, e.Secuencialempresa }, "TIPODIVISION_EMPRESA_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialempresa).HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Secuencialtipodivision).HasColumnName("SECUENCIALTIPODIVISION");

            entity.HasOne(d => d.SecuencialempresaNavigation).WithMany(p => p.TipodivisionEmpresas)
                .HasForeignKey(d => d.Secuencialempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TIPODIVISION_EMPRESA_R02");

            entity.HasOne(d => d.SecuencialtipodivisionNavigation).WithMany(p => p.TipodivisionEmpresas)
                .HasForeignKey(d => d.Secuencialtipodivision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TIPODIVISION_EMPRESA_R01");
        });

        modelBuilder.Entity<Tipogarantiacnb>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("PK_GARANTIAHIPOTECARIACNBS")
                .HasFillFactor(80);

            entity.ToTable("TIPOGARANTIACNBS", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Eshipotecaria).HasColumnName("ESHIPOTECARIA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipoindustrium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasFillFactor(80);

            entity.ToTable("TIPOINDUSTRIA", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<Tipotelefono>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("TIPOTELEFONO_PK")
                .HasFillFactor(80);

            entity.ToTable("TIPOTELEFONO", "FBS_GENERALES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
