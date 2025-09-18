using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Huelladigitalpersona
{
    public int Secuencialpersona { get; set; }

    public byte[] Huelladigital { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
