using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Bancoempresa
{
    public int Secuencial { get; set; }

    public int Secuencialbanco { get; set; }

    public int Secuencialempresa { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Banco SecuencialbancoNavigation { get; set; } = null!;

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
