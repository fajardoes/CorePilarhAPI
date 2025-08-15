using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Tipobanco
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Banco> Bancos { get; set; } = new List<Banco>();
}
