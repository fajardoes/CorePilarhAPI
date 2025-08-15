using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class Calculooficina
{
    public int Secuencial { get; set; }

    public int Secuencialoficina { get; set; }

    public DateTime Fechacalculo { get; set; }

    public DateTime Fechasistema { get; set; }

    public DateTime Fechamaquina { get; set; }

    public string Codigousuario { get; set; } = null!;

    public bool Esdiferido { get; set; }

    public bool Eseventual { get; set; }

    public virtual ICollection<Calculooficinacalculo> Calculooficinacalculos { get; set; } = new List<Calculooficinacalculo>();

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
