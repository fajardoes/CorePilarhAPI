using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class Mensaje
{
    public string Codigo { get; set; } = null!;

    public string Lenguaje { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
