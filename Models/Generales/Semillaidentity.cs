using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Semillaidentity
{
    public string Esquema { get; set; } = null!;

    public string Tabla { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public int Semilla { get; set; }

    public string Reestableceidentity { get; set; } = null!;
}
