using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Zona
{
    public int Secuencial { get; set; }

    public string Siglas { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Oficinazona> Oficinazonas { get; set; } = new List<Oficinazona>();
}
