using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class EmpresaClaveseguridad
{
    public int Secuencial { get; set; }

    public string Clave { get; set; } = null!;

    public int Numeroverificador { get; set; }
}
