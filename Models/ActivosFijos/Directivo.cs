using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Directivo
{
    public string Codigo { get; set; } = null!;

    public int Secuencialpersonanatural { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Directivoparientevinculado> Directivoparientevinculados { get; set; } = new List<Directivoparientevinculado>();
}
