using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class Menuweb
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public string? Menupath { get; set; }

    public string? Icon { get; set; }

    public string? Iconcolor { get; set; }

    public bool Hassubmenu { get; set; }

    public bool Issubmenu { get; set; }

    public int? Parentmenuid { get; set; }

    public virtual ICollection<Menuweb> InverseParentmenu { get; set; } = new List<Menuweb>();

    public virtual ICollection<Menuwebrole> Menuwebroles { get; set; } = new List<Menuwebrole>();

    public virtual Menuweb? Parentmenu { get; set; }
}
