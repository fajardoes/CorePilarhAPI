using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Tipoindustrium
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<DivisionActiecontipoindustrium> DivisionActiecontipoindustria { get; set; } = new List<DivisionActiecontipoindustrium>();
}
