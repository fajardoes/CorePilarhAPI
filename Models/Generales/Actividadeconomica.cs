using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Actividadeconomica
{
    public int Secuencialdivision { get; set; }

    public bool Esproductiva { get; set; }

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public bool Apnfd { get; set; }

    public virtual ICollection<CostoActividadeconomicaDivisionpolitica> CostoActividadeconomicaDivisionpoliticas { get; set; } = new List<CostoActividadeconomicaDivisionpolitica>();

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;
}
