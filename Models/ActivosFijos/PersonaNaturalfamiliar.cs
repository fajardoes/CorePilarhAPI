using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalfamiliar
{
    public int Secuencial { get; set; }

    public int Secuencialpersonanatural { get; set; }

    public int Secuencialpersonafamiliar { get; set; }

    public string Codigoparentesco { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public bool? Soydependiente { get; set; }

    public bool? Esdependiente { get; set; }

    public virtual Parentesco CodigoparentescoNavigation { get; set; } = null!;

    public virtual PersonaNatural SecuencialpersonafamiliarNavigation { get; set; } = null!;

    public virtual PersonaNatural SecuencialpersonanaturalNavigation { get; set; } = null!;
}
