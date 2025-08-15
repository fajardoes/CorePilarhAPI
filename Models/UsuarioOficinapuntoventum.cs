using System;
using System.Collections.Generic;

namespace CorePilarh.Models;

public partial class UsuarioOficinapuntoventum
{
    public string Codigousuario { get; set; } = null!;

    public int Secoficinapuntoventa { get; set; }

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
