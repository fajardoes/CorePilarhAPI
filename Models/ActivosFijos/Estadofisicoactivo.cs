using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Estadofisicoactivo
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();
}
