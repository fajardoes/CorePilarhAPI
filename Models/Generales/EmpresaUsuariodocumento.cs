using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class EmpresaUsuariodocumento
{
    public int Secuencial { get; set; }

    public int Secuencialempresa { get; set; }

    public string Codigousuario { get; set; } = null!;

    public int Ultimonumerodocumentomovimiento { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
