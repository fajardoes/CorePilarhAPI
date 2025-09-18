using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Estadocivil
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Requiereconyuge { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<PersonaNatural> PersonaNaturals { get; set; } = new List<PersonaNatural>();
}
