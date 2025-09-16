using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Directivoparientevinculado
{
    public int Secuencial { get; set; }

    public string Codigodirectivo { get; set; } = null!;

    public string Identificacionpariente { get; set; } = null!;

    public string Nombreunidopariente { get; set; } = null!;

    public string Parentesco { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Directivo CodigodirectivoNavigation { get; set; } = null!;
}
