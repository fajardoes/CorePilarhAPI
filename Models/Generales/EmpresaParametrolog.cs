using System;
using System.Collections.Generic;

namespace CorePilarh.Models.Generales;

public partial class EmpresaParametrolog
{
    public int Secuencialempresa { get; set; }

    public bool AlmacenalogclaveIndividual { get; set; }

    public bool AlmacenalogclaveLote { get; set; }

    public bool Almacenalogaccesousuario { get; set; }

    public bool Almacenalogsalidausuario { get; set; }

    public bool AlmacenalogaccionCamclalot { get; set; }

    public bool AlmacenalogaccionCamferiado { get; set; }

    public bool AlmacenalogaccCamclaprxinglot { get; set; }

    public bool Almacenatiemporespuesta { get; set; }

    public bool Despliegatiemporespuesta { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Empresa SecuencialempresaNavigation { get; set; } = null!;
}
