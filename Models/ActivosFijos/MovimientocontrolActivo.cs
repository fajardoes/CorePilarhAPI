using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class MovimientocontrolActivo
{
    public int Secuencialmovimientocontrol { get; set; }

    public int Secuencialdivestructuraactfijo { get; set; }

    public int Secuencialcuentacontable { get; set; }

    public virtual DivisionestructuraactfijoCond SecuencialdivestructuraactfijoNavigation { get; set; } = null!;
}
