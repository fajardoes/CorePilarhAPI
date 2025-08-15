using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Activooficinaprorrateoarea
{
    public int Secuencial { get; set; }

    public int Secuencialactivooficinaporrateo { get; set; }

    public int Secuencialarea { get; set; }

    public decimal Porcentaje { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Activooficinaprorrateo SecuencialactivooficinaporrateoNavigation { get; set; } = null!;
}
