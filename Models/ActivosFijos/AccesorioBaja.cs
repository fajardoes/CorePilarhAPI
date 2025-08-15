using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class AccesorioBaja
{
    public int Secuencialaccesorio { get; set; }

    public string Motivo { get; set; } = null!;

    public DateTime Fechabaja { get; set; }

    public string Codigousuario { get; set; } = null!;

    public DateTime Fechamaquina { get; set; }

    public DateTime Fechasistema { get; set; }

    public virtual Accesorio SecuencialaccesorioNavigation { get; set; } = null!;
}
