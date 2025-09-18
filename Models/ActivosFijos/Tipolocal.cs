using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Tipolocal
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Esperteneciente { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<PersonaNaturalocupacion> PersonaNaturalocupacions { get; set; } = new List<PersonaNaturalocupacion>();
}
