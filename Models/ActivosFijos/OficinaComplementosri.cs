using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class OficinaComplementosri
{
    public int Secuencialoficina { get; set; }

    public string Codigoestablecimiento { get; set; } = null!;

    public string Codigopuntoemision { get; set; } = null!;

    public string Autorizacion { get; set; } = null!;

    public string? Codigoprovinciasri { get; set; }

    public virtual Oficina SecuencialoficinaNavigation { get; set; } = null!;
}
