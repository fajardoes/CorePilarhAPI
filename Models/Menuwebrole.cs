using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class Menuwebrole
{
    public int Id { get; set; }

    public int? Menuid { get; set; }

    public string? Rolecode { get; set; }

    public virtual Menuweb? Menu { get; set; }

    public virtual Rol? RolecodeNavigation { get; set; }
}
