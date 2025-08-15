using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class TipodivisionEmpresa
{
    public int Secuencial { get; set; }

    public int Secuencialtipodivision { get; set; }

    public int Secuencialempresa { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;

    public virtual Tipodivision SecuencialtipodivisionNavigation { get; set; } = null!;
}
