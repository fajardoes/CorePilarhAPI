using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class ActivoActivacion
{
    public int Secuencialactivo { get; set; }

    public string Codigousuario { get; set; } = null!;

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public int? Secuencialpersonarespini { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
