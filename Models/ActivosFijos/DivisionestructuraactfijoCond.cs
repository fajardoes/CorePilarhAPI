using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class DivisionestructuraactfijoCond
{
    public int Secuencialdivision { get; set; }

    public bool Sedeprecia { get; set; }

    public bool Sereexpresa { get; set; }

    public int Secuencialcuentacontableactivo { get; set; }

    public bool Estaactivo { get; set; }

    public int Numeroverificador { get; set; }

    public virtual CondicionCtacblevalorizacion? CondicionCtacblevalorizacion { get; set; }

    public virtual CondicionCuentacontable? CondicionCuentacontable { get; set; }

    public virtual EstructactfijcondCuentasorden? EstructactfijcondCuentasorden { get; set; }

    public virtual ICollection<Motivobajdivestructuactfijcond> Motivobajdivestructuactfijconds { get; set; } = new List<Motivobajdivestructuactfijcond>();

    public virtual ICollection<MovimientocontrolActivo> MovimientocontrolActivos { get; set; } = new List<MovimientocontrolActivo>();
}
