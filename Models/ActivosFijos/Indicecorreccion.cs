using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Indicecorreccion
{
    public int Secuencial { get; set; }

    public int Secuencialempresa { get; set; }

    public int Secuencialmoneda { get; set; }

    public DateTime Fechaperiodo { get; set; }

    public decimal Indice { get; set; }

    public int Periodoenmeses { get; set; }

    public int Numeroverificador { get; set; }
}
