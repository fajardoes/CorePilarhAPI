using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Area
{
    public int Secuencial { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Codigotipoarea { get; set; } = null!;

    public int Secuencialempresa { get; set; }

    public bool Esoperativa { get; set; }

    public bool Estaactiva { get; set; }

    public bool Pordefecto { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<ActivoArea> ActivoAreas { get; set; } = new List<ActivoArea>();

    public virtual Tipoarea CodigotipoareaNavigation { get; set; } = null!;

    public virtual ICollection<Oficinaarea> Oficinaareas { get; set; } = new List<Oficinaarea>();
}
