using System;
using System.Collections.Generic;

namespace GestionesPilarh.Models;

public partial class EmpresaParametrovalidacionseg
{
    public int Secuencialempresa { get; set; }

    public int Numeroclavesalmacenausuario { get; set; }

    public int Numerointentosingresoclavedia { get; set; }

    public int Numerointentosingresoclalogin { get; set; }

    public int Numerominimocaracteresclave { get; set; }

    public int Numeromaximocaracteresclave { get; set; }

    public bool Requieremayusculasclave { get; set; }

    public bool Requiereminusculasclave { get; set; }

    public bool Requierenumerosclave { get; set; }

    public bool Aceptacaracteresespecialescla { get; set; }

    public int Periodicidadcambioclave { get; set; }

    public bool Revisadireccionequipocliing { get; set; }

    public bool Revisanombreequipoclienteing { get; set; }

    public bool Revisadireccionnomequipocliing { get; set; }

    public int Numeroverificador { get; set; }

    public int Minutosdeinactividadmaxima { get; set; }

    public bool Sesionunicaporusuario { get; set; }
}
