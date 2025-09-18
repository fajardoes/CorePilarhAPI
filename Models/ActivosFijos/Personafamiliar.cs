using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Personafamiliar
{
    public int Secuencial { get; set; }

    public int Secuencialpersonanatural { get; set; }

    public int Secuencialpersonafamiliar { get; set; }

    public string Codigoparentesco { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
