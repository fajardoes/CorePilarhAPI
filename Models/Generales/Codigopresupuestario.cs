using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Codigopresupuestario
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public virtual ICollection<Detallepresupuestoglobal> Detallepresupuestoglobals { get; set; } = new List<Detallepresupuestoglobal>();
}
