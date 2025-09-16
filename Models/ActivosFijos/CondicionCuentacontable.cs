using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class CondicionCuentacontable
{
    public int Secuencialcondicion { get; set; }

    public decimal Porcentajedepreciaciacion { get; set; }

    public int Secuencialctacbledepreciacion { get; set; }

    public int Secuencialcuentacontablegasto { get; set; }

    public int Secuencialcuentacontabledepreciados { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual DivisionestructuraactfijoCond SecuencialcondicionNavigation { get; set; } = null!;
}
