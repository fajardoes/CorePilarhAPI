using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Activoinformacionanterior
{
    public int Secuencialactivo { get; set; }

    public string? Codigoanterior { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
