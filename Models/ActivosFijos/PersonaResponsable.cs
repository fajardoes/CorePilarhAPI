using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PersonaResponsable
{
    public int Secuencialpersona { get; set; }

    public int Secuencialoficinadepartamento { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();

    public virtual Oficinadepartamento SecuencialoficinadepartamentoNavigation { get; set; } = null!;
}
