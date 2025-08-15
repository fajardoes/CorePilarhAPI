using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class ActivoeventualGaranthipotecar
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public int Secuencialgarantiahipotecaria { get; set; }

    public DateOnly Fechasistema { get; set; }

    public DateOnly Fechamaquina { get; set; }

    public string Codigousuario { get; set; } = null!;

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
