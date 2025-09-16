using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class Usuariohorarioingreso
{
    public int Secuencial { get; set; }

    public string Codigousuario { get; set; } = null!;

    public string Dia { get; set; } = null!;

    public int Horainicio { get; set; }

    public int Minutoinicio { get; set; }

    public int Horasvalidez { get; set; }

    public int Minutosvalidez { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual Usuario CodigousuarioNavigation { get; set; } = null!;

    public virtual Horariousuarioingreso? Horariousuarioingreso { get; set; }
}
