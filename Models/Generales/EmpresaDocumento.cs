using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;
public partial class EmpresaDocumento
{
    public int Secuencialempresa { get; set; }

    public int Ultimonumerodocumentomov { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
