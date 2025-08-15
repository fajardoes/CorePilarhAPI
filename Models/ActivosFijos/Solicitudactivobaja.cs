using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Solicitudactivobaja
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public string Codigousuario { get; set; } = null!;

    public int Secuencialoficina { get; set; }

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public string? Comentariobaja { get; set; }

    public string Codigoestsolicitudactivobaja { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public int? Secuencialmotivobaja { get; set; }

    public bool? Eseventual { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;

    public virtual MotivoActivobaja? SecuencialmotivobajaNavigation { get; set; }

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;

    public virtual SolicitudactivobajaCompcausal? SolicitudactivobajaCompcausal { get; set; }

    public virtual ICollection<Solicitudactivobajacambioest> Solicitudactivobajacambioests { get; set; } = new List<Solicitudactivobajacambioest>();

    public virtual ICollection<Solicitudactivobajalote> Solicitudactivobajalotes { get; set; } = new List<Solicitudactivobajalote>();
}
