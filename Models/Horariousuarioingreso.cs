using System;
using System.Collections.Generic;

namespace CorePilarh.Models;

public partial class Horariousuarioingreso
{
    public int Secusuariohorarioingreso { get; set; }

    public int Secuencialhorario { get; set; }

    public virtual Usuariohorarioingreso SecusuariohorarioingresoNavigation { get; set; } = null!;
}
