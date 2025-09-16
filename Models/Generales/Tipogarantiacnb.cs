using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Tipogarantiacnb
{
    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Eshipotecaria { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
