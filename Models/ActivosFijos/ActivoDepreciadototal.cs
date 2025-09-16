using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class ActivoDepreciadototal
{
    public int Secuencialactivo { get; set; }

    public string? Codigousuario { get; set; }

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
