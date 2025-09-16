using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Divisionpolitica
{
    public int Secuencialdivision { get; set; }

    public bool Esurbana { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<CostoActividadeconomicaDivisionpolitica> CostoActividadeconomicaDivisionpoliticas { get; set; } = new List<CostoActividadeconomicaDivisionpolitica>();

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;
}
