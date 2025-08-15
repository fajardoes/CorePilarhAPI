using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Estado
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Numeroverificador { get; set; }
}
