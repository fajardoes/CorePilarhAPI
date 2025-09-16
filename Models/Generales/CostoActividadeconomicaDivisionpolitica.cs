using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class CostoActividadeconomicaDivisionpolitica
{
    public int Secuencial { get; set; }

    public int Secuencialdivisionpolitica { get; set; }

    public int Secuencialactividadeconomica { get; set; }

    public decimal Costo { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Actividadeconomica SecuencialactividadeconomicaNavigation { get; set; } = null!;

    public virtual Divisionpolitica SecuencialdivisionpoliticaNavigation { get; set; } = null!;
}
