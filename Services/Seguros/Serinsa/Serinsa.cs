using GestionesPilarh.Models.DTO;
using GestionesPilarh.Models.DTO.Serinsa;
using GestionesPilarh.Services.Logger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GestionesPilarh.Services.Seguros.Serinsa
{
    public class Serinsa : ISerinsa
    {
        private readonly IConfiguration _configuration;
        private readonly ILoggerAPI _logger;
        private readonly string _connString;

        public Serinsa(IConfiguration configuration, ILoggerAPI logger)
        {
            _configuration = configuration;
            _logger = logger;
            _connString = configuration.GetConnectionString("cadenaSQL") ?? string.Empty;
        }

        public async Task<ActionResult<object>> DevuelvePersona(DtoDevuelvePersonaRequest request)
        {
            try
            {
                DtoEstructuraPersonaSerinsa estructuraPersonaSerinsa = new();
                var response = new ResponseDto();
                const string query = @"select * from FBS_SEGUROS.DEVUELVEPERSONA where cli_numero_documento = @documento";
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@documento", request.Parametro);
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    estructuraPersonaSerinsa = new DtoEstructuraPersonaSerinsa
                                    {
                                        Cli_codimf = await reader.GetFieldValueAsync<int>(0),
                                        Cli_codpai = await reader.IsDBNullAsync(1) ? (int?)null : await reader.GetFieldValueAsync<int?>(1),
                                        Cli_coddep = await reader.IsDBNullAsync(2) ? (int?)null : await reader.GetFieldValueAsync<int?>(2),
                                        Cli_codmun = await reader.IsDBNullAsync(3) ? (int?)null : await reader.GetFieldValueAsync<int?>(3),
                                        Cli_codgen = await reader.IsDBNullAsync(4) ? (int?)null : await reader.GetFieldValueAsync<int?>(4),
                                        Cli_nombres = await reader.GetFieldValueAsync<string>(5),
                                        Cli_apellidos = await reader.GetFieldValueAsync<string>(6),
                                        Cli_numero_documento = await reader.GetFieldValueAsync<string>(7),
                                        Cli_fecha_nacimiento = await reader.GetFieldValueAsync<DateTime>(8),
                                        Cli_lugar_nacimiento = await reader.GetFieldValueAsync<string>(9),
                                        Cli_nacionalidad = await reader.IsDBNullAsync(1) ? (int?)null : await reader.GetFieldValueAsync<int?>(1),
                                        Cli_direccion = await reader.GetFieldValueAsync<string>(10),
                                        Cli_coddep_residencia = await reader.IsDBNullAsync(11) ? (int?)null : await reader.GetFieldValueAsync<int?>(11),
                                        Cli_codmun_residencia = await reader.IsDBNullAsync(12) ? (int?)null : await reader.GetFieldValueAsync<int?>(12),
                                        Cli_ciudad = await reader.GetFieldValueAsync<string>(13),
                                        Cli_con_nombre = await reader.GetFieldValueAsync<string>(14),
                                        Cli_con_nacionalidad = await reader.IsDBNullAsync(1) ? (int?)null : await reader.GetFieldValueAsync<int?>(1),
                                        Cli_con_numero_documento = (string?)null,
                                        Cli_lab_empresa = await reader.IsDBNullAsync(15) ? (string?) null : await reader.GetFieldValueAsync<string>(15),
                                        Cli_lab_profesion = await reader.IsDBNullAsync(16) ? (string?)null : await reader.GetFieldValueAsync<string>(16),
                                        Cli_lab_cargo = await reader.IsDBNullAsync(17) ? (string?)null : await reader.GetFieldValueAsync<string>(17),
                                        Cli_lab_direccion = await reader.IsDBNullAsync(18) ? (string?)null : await reader.GetFieldValueAsync<string>(18),
                                        Cli_lab_ciudad = await reader.IsDBNullAsync(19) ? (string?)null : await reader.GetFieldValueAsync<string>(19),
                                        Cli_lab_fuente = await reader.IsDBNullAsync(20) ? (string?)null : await reader.GetFieldValueAsync<string>(20),
                                    };
                                }
                            }
                        }
                    }
                    if (estructuraPersonaSerinsa.Cli_numero_documento != string.Empty)
                    {
                        return estructuraPersonaSerinsa;
                    }
                    else
                    {
                        response.Message = "No se encuentra la persona.";
                        response.Code = 400;
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo los datos de la persona: " + request.Parametro + " en " + nameof(DevuelvePersona),
                    Level = "Error",
                    Exception = ex.Message
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<ActionResult<object>> DevuelvePersonasFiltradas(DtoDevuelvePersonaRequest request)
        {
            try
            {
                var listaPersonas = new List<DtoEstructuraClientePilarh>();
                const string query = @"SELECT TOP 100 
                                        * 
                                        FROM FBS_SEGUROS.DEVUELVEPERSONASFILTRADAS 
                                        WHERE 
                                           (numerocliente LIKE @parametro 
                                           OR identificacion LIKE @parametro 
                                           OR nombreunido LIKE @parametro)
                                           AND estaactivo = 1 ";
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@parametro", $"%{request.Parametro}%");
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    var persona = new DtoEstructuraClientePilarh
                                    {
                                        NumeroCliente = await reader.GetFieldValueAsync<int>(0),
                                        Identificacion = await reader.GetFieldValueAsync<string>(1),
                                        NombreCompleto = await reader.GetFieldValueAsync<string>(2),
                                        FechaIngreso = await reader.GetFieldValueAsync<DateTime>(3),
                                        Nacionalidad = await reader.GetFieldValueAsync<string>(4),
                                        Profesion = await reader.IsDBNullAsync(5) ? (string?)null : await reader.GetFieldValueAsync<string?>(5),
                                        Agencia = await reader.GetFieldValueAsync<string>(6),
                                        Departamento = await reader.IsDBNullAsync(7) ? (string?)null : await reader.GetFieldValueAsync<string?>(7),
                                        Municipio = await reader.IsDBNullAsync(8) ? (string?)null : await reader.GetFieldValueAsync<string?>(8),
                                    };
                                    listaPersonas.Add(persona);
                                }
                            }
                        }
                    }
                    return listaPersonas;
                }
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo los datos de la persona: " + request.Parametro + " en " + nameof(DevuelvePersona),
                    Level = "Error",
                    Exception = ex.Message
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
    }
}
