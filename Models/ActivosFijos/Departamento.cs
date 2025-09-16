using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Departamento
{
    public int Secuencial { get; set; }

    public string Nombre { get; set; } = null!;

    public string Siglas { get; set; } = null!;

    public int Secuencialempresa { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public bool? Esparaproveduria { get; set; }

    public bool? Esparaactivosfijos { get; set; }

    public virtual ICollection<Oficinadepartamento> Oficinadepartamentos { get; set; } = new List<Oficinadepartamento>();

    public virtual ICollection<PuntodeventaDepartamento> PuntodeventaDepartamentos { get; set; } = new List<PuntodeventaDepartamento>();
}
