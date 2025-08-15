using System;
using System.Collections.Generic;

namespace CorePilarh.Models;

public partial class Usuariorolhistorico
{
    public int Secuencial { get; set; }

    public string Codigousuarioafectado { get; set; } = null!;

    public string Codigousuarioingreso { get; set; } = null!;

    public string Comentario { get; set; } = null!;

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }
}
