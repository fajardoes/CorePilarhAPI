using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Activobajalote
{
    public int Secuencial { get; set; }

    public int Secuencialmotivobaja { get; set; }

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public string Codigousuarioingreso { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual MotivoActivobaja SecuencialmotivobajaNavigation { get; set; } = null!;

    public virtual ICollection<Solicitudactivobajalote> Solicitudactivobajalotes { get; set; } = new List<Solicitudactivobajalote>();
}
