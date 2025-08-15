using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class EmpresaParametromensajerium
{
    public int Secuencialempresa { get; set; }

    public bool Enviamailinternocambioclavelot { get; set; }

    public bool Enviamailexternocambioclavelot { get; set; }

    public bool Enviamailinternocambioclaveind { get; set; }

    public bool Enviamailexternocambioclaveind { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
