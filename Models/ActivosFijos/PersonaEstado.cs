using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaEstado
{
    public int Secuencialpersona { get; set; }

    public bool? Estaactivo { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;
}
