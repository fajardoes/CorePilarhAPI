using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.Generales;

public partial class Division
{
    public int Secuencial { get; set; }

    public int Secuencialnivel { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Numeroverificador { get; set; }

    public virtual Actividadeconomica? Actividadeconomica { get; set; }

    public virtual ICollection<Detallepresupuestoglobal> Detallepresupuestoglobals { get; set; } = new List<Detallepresupuestoglobal>();

    public virtual DivisionActiecontipoindustrium? DivisionActiecontipoindustrium { get; set; }

    public virtual DivisionCodigordep? DivisionCodigordep { get; set; }

    public virtual ICollection<DivisionEnlazaactiecon> DivisionEnlazaactieconSecuencialdivisionactieconNavigations { get; set; } = new List<DivisionEnlazaactiecon>();

    public virtual ICollection<DivisionEnlazaactiecon> DivisionEnlazaactieconSecuencialdivisionactieconcnbsNavigations { get; set; } = new List<DivisionEnlazaactiecon>();

    public virtual ICollection<Divisionbooleana> Divisionbooleanas { get; set; } = new List<Divisionbooleana>();

    public virtual ICollection<Divisioncaracteristicalistum> Divisioncaracteristicalista { get; set; } = new List<Divisioncaracteristicalistum>();

    public virtual ICollection<Divisionfecha> Divisionfechas { get; set; } = new List<Divisionfecha>();

    public virtual ICollection<Divisionnumerica> Divisionnumericas { get; set; } = new List<Divisionnumerica>();

    public virtual Divisionpolitica? Divisionpolitica { get; set; }

    public virtual ICollection<Divisiontexto> Divisiontextos { get; set; } = new List<Divisiontexto>();

    public virtual ICollection<EmpresaParametrooficonsoli> EmpresaParametrooficonsolis { get; set; } = new List<EmpresaParametrooficonsoli>();

    public virtual Padredivision? PadredivisionSecuencialdivisionNavigation { get; set; }

    public virtual ICollection<Padredivision> PadredivisionSecuencialdivisionpadreNavigations { get; set; } = new List<Padredivision>();

    public virtual Niveldivision SecuencialnivelNavigation { get; set; } = null!;
}
