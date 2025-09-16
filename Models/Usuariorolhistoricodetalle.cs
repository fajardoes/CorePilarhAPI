using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class Usuariorolhistoricodetalle
{
    public int Secuencial { get; set; }

    public int Secuencialusuariorolhistorico { get; set; }

    public string Codigorol { get; set; } = null!;

    public bool Seleccionado { get; set; }
}
