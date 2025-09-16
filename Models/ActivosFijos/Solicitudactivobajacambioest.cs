using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Solicitudactivobajacambioest
{
    public int Secuencial { get; set; }

    public int Secuencialsolicitudactivobaja { get; set; }

    public string Codigousuario { get; set; } = null!;

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public string Codigoestsolicitudactivobaja { get; set; } = null!;

    public virtual Solicitudactivobaja SecuencialsolicitudactivobajaNavigation { get; set; } = null!;
}
