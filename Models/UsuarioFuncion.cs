using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class UsuarioFuncion
{
    public string Codigousuario { get; set; } = null!;

    public bool Administradorsistema { get; set; }

    public bool Administradortoken { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
