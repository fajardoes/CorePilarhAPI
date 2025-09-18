using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaNaturalLugarnacimiento
{
    public int Secuencialpersona { get; set; }

    public int Secuencialdivision { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual PersonaNatural SecuencialpersonaNavigation { get; set; } = null!;
}
