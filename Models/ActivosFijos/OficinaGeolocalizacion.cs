using System;
using System.Collections.Generic;

namespace CorePilarh.Models.ActivosFijos;

public partial class OficinaGeolocalizacion
{
    public int Secuencialoficina { get; set; }

    public string Latitud { get; set; } = null!;

    public string Longitud { get; set; } = null!;

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
