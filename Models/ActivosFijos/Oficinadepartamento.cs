using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Oficinadepartamento
{
    public int Secuencial { get; set; }

    public int Secuencialoficina { get; set; }

    public int Secuencialdepartamento { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();

    public virtual ICollection<PersonaResponsable> PersonaResponsables { get; set; } = new List<PersonaResponsable>();

    public virtual Departamento SecuencialdepartamentoNavigation { get; set; } = null!;

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;

    public virtual ICollection<Trasladodetalle> TrasladodetalleSecoficinadepartamentodestinoNavigations { get; set; } = new List<Trasladodetalle>();

    public virtual ICollection<Trasladodetalle> TrasladodetalleSecoficinadepartamentoorigenNavigations { get; set; } = new List<Trasladodetalle>();
}
