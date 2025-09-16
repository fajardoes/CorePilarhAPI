using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tipoarea
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public int Secuencialempresa { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();
}
