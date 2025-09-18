using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Personadocumentoadicionalr
{
    public int Secuencial { get; set; }

    public int Secuencialpersona { get; set; }

    public int Secuencialtipodocumentoadicional { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Persona SecuencialpersonaNavigation { get; set; } = null!;

    public virtual Tipoidentificacion SecuencialtipodocumentoadicionalNavigation { get; set; } = null!;
}
