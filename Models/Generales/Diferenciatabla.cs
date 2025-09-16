using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Diferenciatabla
{
    public int Secuencial { get; set; }

    public string Tabla { get; set; } = null!;

    public int Registrodiferente { get; set; }

    public long? Tiempo { get; set; }
}
