using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Activooficinaprorrateo
{
    public int Secuencial { get; set; }

    public int Secuencialactivo { get; set; }

    public int Secuencialoficina { get; set; }

    public decimal Porcentaje { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Activooficinaprorrateoarea> Activooficinaprorrateoareas { get; set; } = new List<Activooficinaprorrateoarea>();

    public virtual Activo SecuencialactivoNavigation { get; set; } = null!;

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
