using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaFechaultimamodicacion
{
    public int Secuencialpersona { get; set; }

    public DateTime Fechasistemaultimamodificacion { get; set; }

    public DateTime Fechamaquinaultimamodificacion { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
