namespace CorePilarh.Models.DTO
{
    public class ResponseDto
    {
        public string Message { get; set; } = string.Empty;
        public int Code { get; set; } = 0;
        public bool IsValid { get; set; } = false;
        public string Email { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
