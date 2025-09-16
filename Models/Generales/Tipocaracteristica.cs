using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Tipocaracteristica
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Caracteristicatipocaracterist> Caracteristicatipocaracterists { get; set; } = new List<Caracteristicatipocaracterist>();
}
