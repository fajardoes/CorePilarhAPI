using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Tipocorreo
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Esprincipal { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
