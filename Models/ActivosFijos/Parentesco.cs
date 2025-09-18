using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Parentesco
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Esafinidad { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<PersonaNaturalfamiliar> PersonaNaturalfamiliars { get; set; } = new List<PersonaNaturalfamiliar>();
}
