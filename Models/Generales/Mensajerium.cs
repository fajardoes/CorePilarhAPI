using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Mensajerium
{
    public string Codigo { get; set; } = null!;

    public string Plantilla { get; set; } = null!;

    public string NombreSp { get; set; } = null!;

    public int IdSp { get; set; }

    public bool Esautomatico { get; set; }
}
