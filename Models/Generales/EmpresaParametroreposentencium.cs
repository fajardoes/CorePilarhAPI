using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class EmpresaParametroreposentencium
{
    public int Secuencialempresa { get; set; }

    public string Urlservidorftpcentral { get; set; } = null!;

    public string? Pathservidorftpcentral { get; set; }

    public string Userftpcentral { get; set; } = null!;

    public string Passwordftpcentral { get; set; } = null!;

    public string? Urldirectorioofdescon { get; set; }

    public string? Pathdirectorioofdescon { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
