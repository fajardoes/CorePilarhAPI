using System;
using System.Collections.Generic;

namespace CorePilarh.Models;

public partial class Usuario
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Secuencialoficina { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<MensajesFm> MensajesFms { get; set; } = new List<MensajesFm>();

    public virtual UsuarioCadconebasedatoslocal? UsuarioCadconebasedatoslocal { get; set; }

    public virtual UsuarioComplemento? UsuarioComplemento { get; set; }

    public virtual UsuarioFuncion? UsuarioFuncion { get; set; }

    public virtual UsuarioImei? UsuarioImei { get; set; }

    public virtual UsuarioOficinapuntoventum? UsuarioOficinapuntoventum { get; set; }

    public virtual ICollection<Usuarioequipocliente> Usuarioequipoclientes { get; set; } = new List<Usuarioequipocliente>();

    public virtual ICollection<Usuariohorarioingreso> Usuariohorarioingresos { get; set; } = new List<Usuariohorarioingreso>();

    public virtual ICollection<Usuariohorarioreceso> Usuariohorariorecesos { get; set; } = new List<Usuariohorarioreceso>();

    public virtual ICollection<Usuariooficinaconsultum> Usuariooficinaconsulta { get; set; } = new List<Usuariooficinaconsultum>();

    public virtual ICollection<Usuariorol> Usuariorols { get; set; } = new List<Usuariorol>();

    public virtual ICollection<Usuarioroltemporal> Usuarioroltemporals { get; set; } = new List<Usuarioroltemporal>();
}
