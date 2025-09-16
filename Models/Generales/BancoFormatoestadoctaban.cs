using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class BancoFormatoestadoctaban
{
    public int Secuencialbanco { get; set; }

    public string Separador { get; set; } = null!;

    public int Ubicaciondocumentobancario { get; set; }

    public int Ubicacionvalor { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Banco SecuencialbancoNavigation { get; set; } = null!;
}
