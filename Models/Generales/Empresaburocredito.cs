using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Empresaburocredito
{
    public int Secuencial { get; set; }

    public string Nombre { get; set; } = null!;

    public string Urlservicio { get; set; } = null!;

    public string Usuarioservicio { get; set; } = null!;

    public string Claveservicio { get; set; } = null!;

    public string Metodoservicio { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public int? Secuencialreporte { get; set; }

    public int? Secuencialreportecredito { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }
}
