using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class EmpresaParametrobusquedacli
{
    public int Secuencialempresa { get; set; }

    public bool Buscapornumero { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
