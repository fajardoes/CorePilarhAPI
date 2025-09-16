using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Pdum
{
    public int Secuencial { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Oficinapdum> Oficinapda { get; set; } = new List<Oficinapdum>();
}
