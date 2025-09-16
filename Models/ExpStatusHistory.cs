using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class ExpStatusHistory
{
    public int Secuencial { get; set; }

    public string CodigoUsuario { get; set; } = null!;

    public bool EstaactivoAnterior { get; set; }

    public int NumeroverificadorAnterior { get; set; }

    public DateTime Fechasistema { get; set; }

    public DateTime FechaServidorbd { get; set; }
}
