using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class DivisionActiecontipoindustrium
{
    public int Secuencialdivision { get; set; }

    public string Codigotipoindustria { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Tipoindustrium CodigotipoindustriaNavigation { get; set; } = null!;

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;
}
