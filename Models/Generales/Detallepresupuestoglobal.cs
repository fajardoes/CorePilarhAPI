using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class Detallepresupuestoglobal
{
    public int Secuencial { get; set; }

    public int Secuencialdivision { get; set; }

    public string Codigopresupuestario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Valor { get; set; }

    public virtual Codigopresupuestario CodigopresupuestarioNavigation { get; set; } = null!;

    public virtual Division SecuencialdivisionNavigation { get; set; } = null!;
}
