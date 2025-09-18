using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tipocuentareferenciabancarium
{
    public string Codigo { get; set; } = null!;

    public string? Siglas { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Referenciabancarium> Referenciabancaria { get; set; } = new List<Referenciabancarium>();
}
