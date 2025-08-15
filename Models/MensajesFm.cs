using System;
using System.Collections.Generic;

namespace CorePilarh.Models;

public partial class MensajesFm
{
    public int Secuencial { get; set; }

    public string Codigousuario { get; set; } = null!;

    public DateTime Fechasistema { get; set; }

    public string Codigomensaje { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public DateTime Fechamaquina { get; set; }

    public bool Estadomensaje { get; set; }

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
