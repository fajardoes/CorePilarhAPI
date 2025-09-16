using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class Usuariorol
{
    public int Secuencial { get; set; }

    public string Codigousuario { get; set; } = null!;

    public string Codigorol { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Rol CodigorolNavigation { get; set; } = null!;

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
