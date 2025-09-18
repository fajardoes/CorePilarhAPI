using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Juntadirectiva
{
    public int Secuencial { get; set; }

    public int Secuencialempresa { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime Fechainicioperiodo { get; set; }

    public DateTime Fechafinperiodo { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public int? Numeroresolucion { get; set; }

    public int? Numeroacta { get; set; }

    public DateTime? FechaAsamblea { get; set; }

    public virtual ICollection<Juntadirectivaintegrante> Juntadirectivaintegrantes { get; set; } = new List<Juntadirectivaintegrante>();
}
