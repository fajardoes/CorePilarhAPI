using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class Usuariooficinaconsultum
{
    public int Secuencial { get; set; }

    public string Codigousuario { get; set; } = null!;

    public int Secuencialoficina { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
