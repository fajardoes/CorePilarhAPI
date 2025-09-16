using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class ActivoeventualGarantprendarium
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public int Secuencialgarantiaprendaria { get; set; }

    public DateOnly Fechasistema { get; set; }

    public DateOnly Fechamaquina { get; set; }

    public string Codigousuario { get; set; } = null!;

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
