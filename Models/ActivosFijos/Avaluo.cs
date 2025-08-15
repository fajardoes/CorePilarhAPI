using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Avaluo
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public DateTime Fechaavaluo { get; set; }

    public DateTime Fechamaquina { get; set; }

    public decimal Valoractual { get; set; }

    public decimal Porctjdepreciacionacumulada { get; set; }

    public decimal Depreciacionacumuladaactual { get; set; }

    public string Codigousuario { get; set; } = null!;

    public string Concepto { get; set; } = null!;

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;
}
