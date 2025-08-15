using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Motivobajdivestructuactfijcond
{
    public int Secuencial { get; set; }

    public int Secuencialmotivoactivobaja { get; set; }

    public int Secdivestructuraactivofijocond { get; set; }

    public int Secuencialcuentacontable { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual DivisionestructuraactfijoCond SecdivestructuraactivofijocondNavigation { get; set; } = null!;

    public virtual MotivoActivobaja SecuencialmotivoactivobajaNavigation { get; set; } = null!;
}
