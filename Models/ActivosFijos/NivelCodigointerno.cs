using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class NivelCodigointerno
{
    public int Secuencialnivel { get; set; }

    public string Codigointerno { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
