using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class IdentificacionbancariaBanco
{
    public int Secuencialbanco { get; set; }

    public string Swift { get; set; } = null!;

    public string Aba { get; set; } = null!;

    public string Bic { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Banco SecuencialbancoNavigation { get; set; } = null!;
}
