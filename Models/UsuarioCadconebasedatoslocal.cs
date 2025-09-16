using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class UsuarioCadconebasedatoslocal
{
    public string Codigousuario { get; set; } = null!;

    public string Cadenaconexionbasedatoslocal { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
