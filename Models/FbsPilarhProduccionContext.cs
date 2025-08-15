using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CorePilarh.Models;

public partial class FbsPilarhProduccionContext : DbContext
{
    public FbsPilarhProduccionContext()
    {
    }

    public FbsPilarhProduccionContext(DbContextOptions<FbsPilarhProduccionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmpresaParametrovalidacionseg> EmpresaParametrovalidacionsegs { get; set; }

    public virtual DbSet<ExpStatusHistory> ExpStatusHistories { get; set; }

    public virtual DbSet<Horariousuarioingreso> Horariousuarioingresos { get; set; }

    public virtual DbSet<MensajesFm> MensajesFms { get; set; }

    public virtual DbSet<Menuweb> Menuwebs { get; set; }

    public virtual DbSet<Menuwebrole> Menuwebroles { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<UltimaaccionusuarioTemp> UltimaaccionusuarioTemps { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioCadconebasedatoslocal> UsuarioCadconebasedatoslocals { get; set; }

    public virtual DbSet<UsuarioComplemento> UsuarioComplementos { get; set; }

    public virtual DbSet<UsuarioFuncion> UsuarioFuncions { get; set; }

    public virtual DbSet<UsuarioImei> UsuarioImeis { get; set; }

    public virtual DbSet<UsuarioOficinapuntoventum> UsuarioOficinapuntoventa { get; set; }

    public virtual DbSet<Usuarioequipocliente> Usuarioequipoclientes { get; set; }

    public virtual DbSet<Usuariohorarioingreso> Usuariohorarioingresos { get; set; }

    public virtual DbSet<Usuariohorarioreceso> Usuariohorariorecesos { get; set; }

    public virtual DbSet<Usuariooficinaconsultum> Usuariooficinaconsulta { get; set; }

    public virtual DbSet<Usuariorol> Usuariorols { get; set; }

    public virtual DbSet<Usuariorolhistorico> Usuariorolhistoricos { get; set; }

    public virtual DbSet<Usuariorolhistoricodetalle> Usuariorolhistoricodetalles { get; set; }

    public virtual DbSet<Usuarioroltemporal> Usuarioroltemporals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmpresaParametrovalidacionseg>(entity =>
        {
            entity.HasKey(e => e.Secuencialempresa)
                .HasName("EMPRESA_PARAMETROVALIDACION_PK")
                .HasFillFactor(80);

            entity.ToTable("EMPRESA_PARAMETROVALIDACIONSEG", "FBS_SEGURIDADES");

            entity.Property(e => e.Secuencialempresa)
                .ValueGeneratedNever()
                .HasColumnName("SECUENCIALEMPRESA");
            entity.Property(e => e.Aceptacaracteresespecialescla).HasColumnName("ACEPTACARACTERESESPECIALESCLA");
            entity.Property(e => e.Minutosdeinactividadmaxima).HasColumnName("MINUTOSDEINACTIVIDADMAXIMA");
            entity.Property(e => e.Numeroclavesalmacenausuario).HasColumnName("NUMEROCLAVESALMACENAUSUARIO");
            entity.Property(e => e.Numerointentosingresoclalogin).HasColumnName("NUMEROINTENTOSINGRESOCLALOGIN");
            entity.Property(e => e.Numerointentosingresoclavedia).HasColumnName("NUMEROINTENTOSINGRESOCLAVEDIA");
            entity.Property(e => e.Numeromaximocaracteresclave).HasColumnName("NUMEROMAXIMOCARACTERESCLAVE");
            entity.Property(e => e.Numerominimocaracteresclave).HasColumnName("NUMEROMINIMOCARACTERESCLAVE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Periodicidadcambioclave).HasColumnName("PERIODICIDADCAMBIOCLAVE");
            entity.Property(e => e.Requieremayusculasclave).HasColumnName("REQUIEREMAYUSCULASCLAVE");
            entity.Property(e => e.Requiereminusculasclave).HasColumnName("REQUIEREMINUSCULASCLAVE");
            entity.Property(e => e.Requierenumerosclave).HasColumnName("REQUIERENUMEROSCLAVE");
            entity.Property(e => e.Revisadireccionequipocliing).HasColumnName("REVISADIRECCIONEQUIPOCLIING");
            entity.Property(e => e.Revisadireccionnomequipocliing).HasColumnName("REVISADIRECCIONNOMEQUIPOCLIING");
            entity.Property(e => e.Revisanombreequipoclienteing).HasColumnName("REVISANOMBREEQUIPOCLIENTEING");
            entity.Property(e => e.Sesionunicaporusuario).HasColumnName("SESIONUNICAPORUSUARIO");
        });

        modelBuilder.Entity<ExpStatusHistory>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("PK__expStatu__BC4935D24DB5BA60")
                .HasFillFactor(80);

            entity.ToTable("expStatusHistory", "FBS_SEGURIDADES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.CodigoUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CODIGO_USUARIO");
            entity.Property(e => e.EstaactivoAnterior).HasColumnName("ESTAACTIVO_ANTERIOR");
            entity.Property(e => e.FechaServidorbd)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_SERVIDORBD");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.NumeroverificadorAnterior).HasColumnName("NUMEROVERIFICADOR_ANTERIOR");
        });

        modelBuilder.Entity<Horariousuarioingreso>(entity =>
        {
            entity.HasKey(e => e.Secusuariohorarioingreso)
                .HasName("PK_HORARIOUSUARIOINGRESO_1")
                .HasFillFactor(80);

            entity.ToTable("HORARIOUSUARIOINGRESO", "FBS_SEGURIDADES");

            entity.Property(e => e.Secusuariohorarioingreso)
                .ValueGeneratedNever()
                .HasColumnName("SECUSUARIOHORARIOINGRESO");
            entity.Property(e => e.Secuencialhorario).HasColumnName("SECUENCIALHORARIO");

            entity.HasOne(d => d.SecusuariohorarioingresoNavigation).WithOne(p => p.Horariousuarioingreso)
                .HasForeignKey<Horariousuarioingreso>(d => d.Secusuariohorarioingreso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HORARIOUSUARIOINGRESO_USUARIOHORARIOINGRESO");
        });

        modelBuilder.Entity<MensajesFm>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("MENSAJES_FMS", "FBS_SEGURIDADES");

            entity.HasIndex(e => new { e.Codigousuario, e.Estadomensaje }, "IX_MENSAJES_FMS_CODIGOUSUARIO_ESTADOMENSAJE").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigomensaje)
                .HasMaxLength(200)
                .HasColumnName("CODIGOMENSAJE");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Estadomensaje).HasColumnName("ESTADOMENSAJE");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(500)
                .HasColumnName("MENSAJE");

            entity.HasOne(d => d.CodigousuarioNavigation).WithMany(p => p.MensajesFms)
                .HasForeignKey(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENSAJES_FMS_USUARIO");
        });

        modelBuilder.Entity<Menuweb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MENUWEB__3214EC272C04DC37");

            entity.ToTable("MENUWEB", "FBS_SEGURIDADES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hassubmenu).HasColumnName("HASSUBMENU");
            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .HasColumnName("ICON");
            entity.Property(e => e.Iconcolor)
                .HasMaxLength(20)
                .HasColumnName("ICONCOLOR");
            entity.Property(e => e.Issubmenu).HasColumnName("ISSUBMENU");
            entity.Property(e => e.Label)
                .HasMaxLength(100)
                .HasColumnName("LABEL");
            entity.Property(e => e.Menupath)
                .HasMaxLength(255)
                .HasColumnName("MENUPATH");
            entity.Property(e => e.Parentmenuid).HasColumnName("PARENTMENUID");

            entity.HasOne(d => d.Parentmenu).WithMany(p => p.InverseParentmenu)
                .HasForeignKey(d => d.Parentmenuid)
                .HasConstraintName("FK__MENUWEB__PARENTM__009F5C1F");
        });

        modelBuilder.Entity<Menuwebrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MENUWEBR__3214EC2725DD7D7F");

            entity.ToTable("MENUWEBROLES", "FBS_SEGURIDADES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Menuid).HasColumnName("MENUID");
            entity.Property(e => e.Rolecode)
                .HasMaxLength(40)
                .HasColumnName("ROLECODE");

            entity.HasOne(d => d.Menu).WithMany(p => p.Menuwebroles)
                .HasForeignKey(d => d.Menuid)
                .HasConstraintName("FK__MENUWEBRO__MENUI__037BC8CA");

            entity.HasOne(d => d.RolecodeNavigation).WithMany(p => p.Menuwebroles)
                .HasForeignKey(d => d.Rolecode)
                .HasConstraintName("FK__MENUWEBRO__ROLEC__046FED03");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("ROL_PK")
                .HasFillFactor(80);

            entity.ToTable("ROL", "FBS_SEGURIDADES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(40)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(500)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
        });

        modelBuilder.Entity<UltimaaccionusuarioTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ULTIMAACCIONUSUARIO_TEMP", "FBS_SEGURIDADES");

            entity.Property(e => e.Agencia)
                .HasMaxLength(800)
                .HasColumnName("AGENCIA");
            entity.Property(e => e.Codigoaccion)
                .HasMaxLength(100)
                .HasColumnName("CODIGOACCION");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Criptografiaregistro)
                .HasMaxLength(1000)
                .HasColumnName("CRIPTOGRAFIAREGISTRO");
            entity.Property(e => e.Descripcionaccion)
                .HasMaxLength(1000)
                .HasColumnName("DESCRIPCIONACCION");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
            entity.Property(e => e.Ipmaquina)
                .HasMaxLength(50)
                .HasColumnName("IPMAQUINA");
            entity.Property(e => e.Maquinaingreso)
                .HasMaxLength(200)
                .HasColumnName("MAQUINAINGRESO");
            entity.Property(e => e.Modulo)
                .HasMaxLength(100)
                .HasColumnName("MODULO");
            entity.Property(e => e.Nombrecliente)
                .HasMaxLength(200)
                .HasColumnName("NOMBRECLIENTE");
            entity.Property(e => e.Numoperaafectada)
                .HasMaxLength(25)
                .HasColumnName("NUMOPERAAFECTADA");
            entity.Property(e => e.Pantalla)
                .HasMaxLength(300)
                .HasColumnName("PANTALLA");
            entity.Property(e => e.Secuencial)
                .ValueGeneratedOnAdd()
                .HasColumnName("SECUENCIAL");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Codigo)
                .HasName("USUARIO_PK")
                .HasFillFactor(80);

            entity.ToTable("USUARIO", "FBS_SEGURIDADES", tb => tb.HasTrigger("USUARIOCAMBIOESTADO"));

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");
        });

        modelBuilder.Entity<UsuarioCadconebasedatoslocal>(entity =>
        {
            entity.HasKey(e => e.Codigousuario).HasFillFactor(80);

            entity.ToTable("USUARIO_CADCONEBASEDATOSLOCAL", "FBS_SEGURIDADES");

            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Cadenaconexionbasedatoslocal)
                .HasMaxLength(500)
                .HasColumnName("CADENACONEXIONBASEDATOSLOCAL");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigousuarioNavigation).WithOne(p => p.UsuarioCadconebasedatoslocal)
                .HasForeignKey<UsuarioCadconebasedatoslocal>(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO_CADCONEBASEDATOSLOCAL_USUARIO");
        });

        modelBuilder.Entity<UsuarioComplemento>(entity =>
        {
            entity.HasKey(e => e.Codigousuario)
                .HasName("USUARIO_COMPLEMENTO_PK")
                .HasFillFactor(80);

            entity.ToTable("USUARIO_COMPLEMENTO", "FBS_SEGURIDADES");

            entity.HasIndex(e => e.Secuencialpersona, "IX_USUARIO_COMPLEMENTO").HasFillFactor(80);

            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Cambioclaveproximoingreso).HasColumnName("CAMBIOCLAVEPROXIMOINGRESO");
            entity.Property(e => e.Clave)
                .HasMaxLength(1000)
                .HasColumnName("CLAVE");
            entity.Property(e => e.Emailinterno)
                .HasMaxLength(200)
                .HasColumnName("EMAILINTERNO");
            entity.Property(e => e.Esinterno).HasColumnName("ESINTERNO");
            entity.Property(e => e.Fechacreacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHACREACION");
            entity.Property(e => e.Fechaultimocambioclave)
                .HasColumnType("datetime")
                .HasColumnName("FECHAULTIMOCAMBIOCLAVE");
            entity.Property(e => e.Logreplica).HasColumnName("LOGREPLICA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Periodicidadcambioclave).HasColumnName("PERIODICIDADCAMBIOCLAVE");
            entity.Property(e => e.Permiteingresosistema).HasColumnName("PERMITEINGRESOSISTEMA");
            entity.Property(e => e.Permitereplica).HasColumnName("PERMITEREPLICA");
            entity.Property(e => e.Puedeconsultarotrosusuarios).HasColumnName("PUEDECONSULTAROTROSUSUARIOS");
            entity.Property(e => e.Secuencialpersona).HasColumnName("SECUENCIALPERSONA");

            entity.HasOne(d => d.CodigousuarioNavigation).WithOne(p => p.UsuarioComplemento)
                .HasForeignKey<UsuarioComplemento>(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SYS_C0031868");
        });

        modelBuilder.Entity<UsuarioFuncion>(entity =>
        {
            entity.HasKey(e => e.Codigousuario).HasFillFactor(80);

            entity.ToTable("USUARIO_FUNCION", "FBS_SEGURIDADES");

            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Administradorsistema).HasColumnName("ADMINISTRADORSISTEMA");
            entity.Property(e => e.Administradortoken).HasColumnName("ADMINISTRADORTOKEN");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigousuarioNavigation).WithOne(p => p.UsuarioFuncion)
                .HasForeignKey<UsuarioFuncion>(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO_FUNCION_USUARIO");
        });

        modelBuilder.Entity<UsuarioImei>(entity =>
        {
            entity.HasKey(e => e.Codigousuario).HasFillFactor(80);

            entity.ToTable("USUARIO_IMEI", "FBS_SEGURIDADES");

            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Imei)
                .HasMaxLength(50)
                .HasColumnName("IMEI");

            entity.HasOne(d => d.CodigousuarioNavigation).WithOne(p => p.UsuarioImei)
                .HasForeignKey<UsuarioImei>(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO_IMEI_USUARIO");
        });

        modelBuilder.Entity<UsuarioOficinapuntoventum>(entity =>
        {
            entity.HasKey(e => e.Codigousuario).HasFillFactor(80);

            entity.ToTable("USUARIO_OFICINAPUNTOVENTA", "FBS_SEGURIDADES");

            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Secoficinapuntoventa).HasColumnName("SECOFICINAPUNTOVENTA");

            entity.HasOne(d => d.CodigousuarioNavigation).WithOne(p => p.UsuarioOficinapuntoventum)
                .HasForeignKey<UsuarioOficinapuntoventum>(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO_OFICINAPUNTOVENTA_USUARIO");
        });

        modelBuilder.Entity<Usuarioequipocliente>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("USUARIOEQUIPOCLIENTE_PK")
                .HasFillFactor(80);

            entity.ToTable("USUARIOEQUIPOCLIENTE", "FBS_SEGURIDADES");

            entity.HasIndex(e => e.Codigousuario, "USUARIOEQUIPOCLIENTE_I01").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.DireccionequipoOcteto1)
                .HasMaxLength(6)
                .HasColumnName("DIRECCIONEQUIPO_OCTETO1");
            entity.Property(e => e.DireccionequipoOcteto2)
                .HasMaxLength(6)
                .HasColumnName("DIRECCIONEQUIPO_OCTETO2");
            entity.Property(e => e.DireccionequipoOcteto3)
                .HasMaxLength(6)
                .HasColumnName("DIRECCIONEQUIPO_OCTETO3");
            entity.Property(e => e.DireccionequipoOcteto4)
                .HasMaxLength(6)
                .HasColumnName("DIRECCIONEQUIPO_OCTETO4");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Nombreequipo)
                .HasMaxLength(100)
                .HasColumnName("NOMBREEQUIPO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigousuarioNavigation).WithMany(p => p.Usuarioequipoclientes)
                .HasForeignKey(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOEQUIPOCLIENTE_R01");
        });

        modelBuilder.Entity<Usuariohorarioingreso>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("USUARIOHORARIOINGRESO_PK")
                .HasFillFactor(80);

            entity.ToTable("USUARIOHORARIOINGRESO", "FBS_SEGURIDADES");

            entity.HasIndex(e => e.Codigousuario, "USUARIOHORARIOINGRESO_I01").HasFillFactor(80);

            entity.HasIndex(e => new { e.Codigousuario, e.Dia }, "USUARIOHORARIOINGRESO_IX")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Dia)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("DIA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Horainicio).HasColumnName("HORAINICIO");
            entity.Property(e => e.Horasvalidez).HasColumnName("HORASVALIDEZ");
            entity.Property(e => e.Minutoinicio).HasColumnName("MINUTOINICIO");
            entity.Property(e => e.Minutosvalidez).HasColumnName("MINUTOSVALIDEZ");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigousuarioNavigation).WithMany(p => p.Usuariohorarioingresos)
                .HasForeignKey(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOHORARIOINGRESO_R01");
        });

        modelBuilder.Entity<Usuariohorarioreceso>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("USUARIOHORARIORECESO_PK")
                .HasFillFactor(80);

            entity.ToTable("USUARIOHORARIORECESO", "FBS_SEGURIDADES");

            entity.HasIndex(e => e.Codigousuario, "USUARIOHORARIORECESO_I01").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Dia)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("DIA");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Horainicio).HasColumnName("HORAINICIO");
            entity.Property(e => e.Horasduracion).HasColumnName("HORASDURACION");
            entity.Property(e => e.Minutoinicio).HasColumnName("MINUTOINICIO");
            entity.Property(e => e.Minutosduracion).HasColumnName("MINUTOSDURACION");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigousuarioNavigation).WithMany(p => p.Usuariohorariorecesos)
                .HasForeignKey(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOHORARIORECESO_R01");
        });

        modelBuilder.Entity<Usuariooficinaconsultum>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("USUARIOOFICINACONSULTA_PK")
                .HasFillFactor(80);

            entity.ToTable("USUARIOOFICINACONSULTA", "FBS_SEGURIDADES");

            entity.HasIndex(e => new { e.Codigousuario, e.Secuencialoficina }, "USUARIOOFICINACONSULTA_I01")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => e.Codigousuario, "USUARIOOFICINACONSULTA_I02").HasFillFactor(100);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Estaactiva).HasColumnName("ESTAACTIVA");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");
            entity.Property(e => e.Secuencialoficina).HasColumnName("SECUENCIALOFICINA");

            entity.HasOne(d => d.CodigousuarioNavigation).WithMany(p => p.Usuariooficinaconsulta)
                .HasForeignKey(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOOFICINACONSULTA_R01");
        });

        modelBuilder.Entity<Usuariorol>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("SYS_C0030574")
                .HasFillFactor(80);

            entity.ToTable("USUARIOROL", "FBS_SEGURIDADES");

            entity.HasIndex(e => new { e.Codigousuario, e.Codigorol }, "USUARIOROL_I01")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.Codigousuario, "USUARIOROL_I02").HasFillFactor(80);

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigorol)
                .HasMaxLength(40)
                .HasColumnName("CODIGOROL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigorolNavigation).WithMany(p => p.Usuariorols)
                .HasForeignKey(d => d.Codigorol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOROL_R02");

            entity.HasOne(d => d.CodigousuarioNavigation).WithMany(p => p.Usuariorols)
                .HasForeignKey(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOROL_R01");
        });

        modelBuilder.Entity<Usuariorolhistorico>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("USUARIOROLHISTORICO", "FBS_SEGURIDADES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigousuarioafectado)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIOAFECTADO");
            entity.Property(e => e.Codigousuarioingreso)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIOINGRESO");
            entity.Property(e => e.Comentario).HasColumnName("COMENTARIO");
            entity.Property(e => e.Fechamaquina)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINA");
            entity.Property(e => e.Fechasistema)
                .HasColumnType("datetime")
                .HasColumnName("FECHASISTEMA");
        });

        modelBuilder.Entity<Usuariorolhistoricodetalle>(entity =>
        {
            entity.HasKey(e => e.Secuencial).HasFillFactor(80);

            entity.ToTable("USUARIOROLHISTORICODETALLE", "FBS_SEGURIDADES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigorol)
                .HasMaxLength(40)
                .HasColumnName("CODIGOROL");
            entity.Property(e => e.Secuencialusuariorolhistorico).HasColumnName("SECUENCIALUSUARIOROLHISTORICO");
            entity.Property(e => e.Seleccionado).HasColumnName("SELECCIONADO");
        });

        modelBuilder.Entity<Usuarioroltemporal>(entity =>
        {
            entity.HasKey(e => e.Secuencial)
                .HasName("USUARIOROLTEMPORAL_PK")
                .HasFillFactor(80);

            entity.ToTable("USUARIOROLTEMPORAL", "FBS_SEGURIDADES");

            entity.Property(e => e.Secuencial).HasColumnName("SECUENCIAL");
            entity.Property(e => e.Codigorol)
                .HasMaxLength(40)
                .HasColumnName("CODIGOROL");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(20)
                .HasColumnName("CODIGOUSUARIO");
            entity.Property(e => e.Estaactivo).HasColumnName("ESTAACTIVO");
            entity.Property(e => e.Fechamaquinafin)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINAFIN");
            entity.Property(e => e.Fechamaquinainicio)
                .HasColumnType("datetime")
                .HasColumnName("FECHAMAQUINAINICIO");
            entity.Property(e => e.Numeroverificador).HasColumnName("NUMEROVERIFICADOR");

            entity.HasOne(d => d.CodigorolNavigation).WithMany(p => p.Usuarioroltemporals)
                .HasForeignKey(d => d.Codigorol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOROLTEMPORAL_R02");

            entity.HasOne(d => d.CodigousuarioNavigation).WithMany(p => p.Usuarioroltemporals)
                .HasForeignKey(d => d.Codigousuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOROLTEMPORAL_R01");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
