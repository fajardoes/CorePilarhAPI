using GestionesPilarh.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GestionesPilarh.Services.Logger
{
    public class LoggerAPI : ILoggerAPI
    {
        private readonly IConfiguration _configuration;
        private readonly string _connString;

        public LoggerAPI(IConfiguration configuration)
        {
            _configuration = configuration;
            _connString = configuration.GetConnectionString("cadenaLogs") ?? "";
        }
        public async Task<ActionResult<object>> LogAction(LogsDto request)
        {
            var response = new ResponseDto();
            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    var query = "INSERT INTO APICORE.APILOGS(Message, Level, TimeStamp, Exception) VALUES (@Message, @Level, GETDATE(), @Exception)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Message", request.Message);
                        command.Parameters.AddWithValue("@Level", request.Level);
                        command.Parameters.AddWithValue("@Exception", request.Exception);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                    response.Message = "Log registrado";
                    response.Code = 200;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Code = 500;
                return response;
            }
        }
    }
}
