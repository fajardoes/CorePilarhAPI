using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class CondicionCtacblevalorizacion
{
    public int Secuencialcondicion { get; set; }

    public int Secuencialcuentactablevalorizacion { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual DivisionestructuraactfijoCond SecuencialcondicionNavigation { get; set; } = null!;
}
