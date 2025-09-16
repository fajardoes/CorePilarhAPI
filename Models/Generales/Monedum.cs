using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Monedum
{
    public int Secuencial { get; set; }

    public string Nombre { get; set; } = null!;

    public string Simbolo { get; set; } = null!;

    public bool Estaactiva { get; set; }

    public int Numeroverificador { get; set; }

    public string? Codigopais { get; set; }

    public virtual Pai? CodigopaisNavigation { get; set; }

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
