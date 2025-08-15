using System;
using System.Collections.Generic;

namespace CorePilarh.Models;

public partial class UsuarioImei
{
    public string Codigousuario { get; set; } = null!;

    public string Imei { get; set; } = null!;

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
