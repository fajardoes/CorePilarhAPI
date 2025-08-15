namespace CorePilarh.Models.DTO.ActivosFijos
{
    public class DtoPadreDivision
    {
        public int SecuencialDivision { get; set; } = 0;
        public int? SecuencialDivisionPadre { get; set; } = 0;
        public int NumeroVerificador { get; set; } = 0;
    }


    public class DtoDivision
    {
        public int Secuencial { get; set; } = 0;
        public int SecuencialNivel { get; set; } = 0;
        public string Codigo { get; set; } = string.Empty;
        public string Nombre {  get; set; } = string.Empty;
        public int NumeroVerificador { get; set; } = 0;
    }

}
