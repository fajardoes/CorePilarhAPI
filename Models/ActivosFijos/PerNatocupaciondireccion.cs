using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class PerNatocupaciondireccion
{
    public int Secuencialpernatocupacion { get; set; }

    public string Direccionformateada { get; set; } = null!;

    public virtual PersonaNaturalocupacion SecuencialpernatocupacionNavigation { get; set; } = null!;
}
