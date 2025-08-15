using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Trasladodetalle
{
    public int Secuencial { get; set; }

    public int Secuencialtraslado { get; set; }

    public int Secuencialactivo { get; set; }

    public int Secpersonaresponsableorigen { get; set; }

    public int Secoficinadepartamentoorigen { get; set; }

    public int Secpersonaresponsabledestino { get; set; }

    public int Secoficinadepartamentodestino { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Oficinadepartamento SecoficinadepartamentodestinoNavigation { get; set; } = null!;

    public virtual Oficinadepartamento SecoficinadepartamentoorigenNavigation { get; set; } = null!;

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;

    public virtual Traslado SecuencialtrasladoNavigation { get; set; } = null!;
}
