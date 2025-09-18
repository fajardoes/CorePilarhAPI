using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models.ActivosFijos;

public partial class Solicitudregistroactadefuncion
{
    public int Secuencial { get; set; }

    public DateOnly Fechasistema { get; set; }

    public DateOnly Fechafallecimiento { get; set; }

    public DateOnly Fechaactadefuncion { get; set; }

    public string Observacion { get; set; } = null!;

    public string Numeroregistroacta { get; set; } = null!;

    public string Codigousuario { get; set; } = null!;

    public string Codigoestado { get; set; } = null!;

    public int SecuencialpersonaNatural { get; set; }

    public virtual Estadosolicregistroactadefunc CodigoestadoNavigation { get; set; } = null!;

    public virtual ICollection<PersonaNaturalFallecimiento> PersonaNaturalFallecimientos { get; set; } = new List<PersonaNaturalFallecimiento>();

    public virtual PersonaNatural SecuencialpersonaNaturalNavigation { get; set; } = null!;
}
