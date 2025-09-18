using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Rangoedad
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Edadinicio { get; set; }

    public int Edadfinal { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual ICollection<Tipoidentificacionrangoedad> Tipoidentificacionrangoedads { get; set; } = new List<Tipoidentificacionrangoedad>();
}
