using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Padredivision
{
    public int Secuencialdivision { get; set; }

    public int Secuencialdivisionpadre { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;

    public virtual Division SecuencialdivisionpadreNavigation { get; set; } = null!;
}
