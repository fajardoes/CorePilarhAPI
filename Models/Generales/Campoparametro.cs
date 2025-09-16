using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Campoparametro
{
    public int Secuencial { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Estexto { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual CampoparametroTexto? CampoparametroTexto { get; set; }

    public virtual ICollection<Campoparametrovalorlistum> Campoparametrovalorlista { get; set; } = new List<Campoparametrovalorlistum>();
}
