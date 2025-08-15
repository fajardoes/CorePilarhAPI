namespace CorePilarh.Models.DTO.Serinsa
{
    public class DtoEstructuraClientePilarh
    {
        public int NumeroCliente { get; set; } = 0;
        public string Identificacion { get; set; } = string.Empty;
        public string NombreCompleto {  get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; } = DateTime.MinValue;
        public string Nacionalidad {  get; set; } = string.Empty;
        public string? Profesion {  get; set; } = string.Empty;
        public string? Agencia {  get; set; } = string.Empty;
        public string? Departamento { get; set; } = string.Empty;
        public string? Municipio { get; set; } = string.Empty;
    }
}
