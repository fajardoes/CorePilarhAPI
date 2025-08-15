using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class EmpresaInformacionsri
{
    public int Secuencialempresa { get; set; }

    public string Numeroruc { get; set; } = null!;

    public string Razonsocial { get; set; } = null!;

    public string Direccionmatriz { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Tipoidrepresentantelegal { get; set; } = null!;

    public string Idrepresentantelegal { get; set; } = null!;

    public string Ruccontador { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
