using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Activonumerica
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public string Codigocaracteristica { get; set; } = null!;

    public int Valorentero { get; set; }

    public int Valordecimal { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
