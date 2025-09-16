using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class Rol
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Menuwebrole> Menuwebroles { get; set; } = new List<Menuwebrole>();

    public virtual ICollection<Usuariorol> Usuariorols { get; set; } = new List<Usuariorol>();

    public virtual ICollection<Usuarioroltemporal> Usuarioroltemporals { get; set; } = new List<Usuarioroltemporal>();
}
