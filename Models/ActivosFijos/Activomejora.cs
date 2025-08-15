using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Activomejora
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Valor { get; set; }

    public string Observacion { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
