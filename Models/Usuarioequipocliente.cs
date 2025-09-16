using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class Usuarioequipocliente
{
    public int Secuencial { get; set; }

    public string Codigousuario { get; set; } = null!;

    public string DireccionequipoOcteto1 { get; set; } = null!;

    public string DireccionequipoOcteto2 { get; set; } = null!;

    public string DireccionequipoOcteto3 { get; set; } = null!;

    public string DireccionequipoOcteto4 { get; set; } = null!;

    public string Nombreequipo { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
