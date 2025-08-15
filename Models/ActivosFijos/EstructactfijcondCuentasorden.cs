using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class EstructactfijcondCuentasorden
{
    public int Secdivisionestruactfijcond { get; set; }

    public int Seccuentacbleordendeudora { get; set; }

    public int Seccuentacbleordenacreedora { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual DivisionestructuraactfijoCond SecdivisionestruactfijcondNavigation { get; set; } = null!;
}
