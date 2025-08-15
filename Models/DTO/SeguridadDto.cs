namespace CorePilarh.Models.DTO
{
    public class DtoValidateUserRequest
    {
        public string CodigoUsuario { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PushToken { get; set; } = string.Empty;
    }
}
