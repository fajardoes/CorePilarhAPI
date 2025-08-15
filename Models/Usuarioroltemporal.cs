using System;
using System.Collections.Generic;

namespace CorePilarh.Models;

public partial class Usuarioroltemporal
{
    public int Secuencial { get; set; }

    public string Codigousuario { get; set; } = null!;

    public string Codigorol { get; set; } = null!;

    public DateTime Fechamaquinainicio { get; set; }

    public DateTime Fechamaquinafin { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Rol CodigorolNavigation { get; set; } = null!;

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;
}
