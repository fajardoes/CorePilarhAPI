namespace GestionesPilarh.Models.DTO.Serinsa
{
    public class DtoEstructuraPersonaSerinsa
    {
        public int Cli_codigo { get; set; } = 0;
        public int Cli_codimf { get; set; } = 0;
        public int? Cli_codpai { get; set; } = 0;
        public int? Cli_coddep { get; set; } = 0;
        public int? Cli_codmun { get; set; } = 0;
        public int? Cli_codgen { get; set; } = 0;
        public string Cli_nombres { get; set; } = string.Empty;
        public string Cli_apellidos { get; set; } = string.Empty;
        public string Cli_numero_documento { get; set; } = string.Empty;
        public DateTime Cli_fecha_nacimiento { get; set; } = DateTime.MinValue;
        public string Cli_lugar_nacimiento { get; set; } = string.Empty;
        public int? Cli_nacionalidad { get; set; } = 0;
        public string Cli_direccion { get; set; } = string.Empty;
        public int? Cli_coddep_residencia { get; set; } = 0;
        public int? Cli_codmun_residencia { get; set; } = 0;
        public string Cli_ciudad { get; set; } = string.Empty;
        public string Cli_con_nombre { get; set; } = string.Empty; //nombre del conyugue
        public int? Cli_con_nacionalidad { get; set; } = 0; //nacionalidad del conyugue
        public string? Cli_con_numero_documento { get; set; } = string.Empty; // documento identificador del conyugue
        public string? Cli_lab_empresa {  get; set; } = string.Empty;
        public string? Cli_lab_profesion {  get; set; } = string.Empty;
        public string? Cli_lab_cargo {  get; set; } = string.Empty;
        public string? Cli_lab_direccion { get; set; } = string.Empty;
        public string? Cli_lab_ciudad { get; set; } = string.Empty;
        public string? Cli_lab_fuente {  get; set; } = string.Empty;
    }
}
