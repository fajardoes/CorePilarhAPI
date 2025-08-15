using CorePilarh.Models;
using CorePilarh.Models.DTO;
using CorePilarh.Models.DTO.Finanzas;
using CorePilarh.Services.LoggerAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Text;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace CorePilarh.Services.Seguridad
{
    public class Seguridad : ISeguridad
    {

        private readonly string masterKey;
        private readonly IConfiguration _configuration;
        private readonly ILoggerAPI _logger;
        private readonly string _connString;
        private readonly FbsPilarhProduccionContext _context;

        public Seguridad(IConfiguration configuration, ILoggerAPI logger, FbsPilarhProduccionContext context)
        {
            _context = context;
            _configuration = configuration;
            _logger = logger;
            _connString = configuration.GetConnectionString("cadenaSQL") ?? "";
            var masterKeySetting = configuration.GetSection("settings:masterKey").Value;
            if (masterKeySetting == null)
            {
                masterKey = "";
            }
            else
            {
                masterKey = masterKeySetting;
            }

        }

        public async Task<ActionResult<object>> ValidateUser(DtoValidateUserRequest request)
        {
            try
            {
                DatosUsuario datosUsuario = null;
                var response = new ResponseDto();
                string token = Helpers.Helpers.TokenHandler.GenerateToken(request.CodigoUsuario, masterKey);
                const string query = @"select  CAST(case when UPPER(SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA1', 
 ( CONVERT(varchar(20),RTRIM(@usuario)) + @clave) )), 3, 40)) =
 uc.CLAVE then 1 else 0 end as BIT) as esValido,  UC.FECHAULTIMOCAMBIOCLAVE, UC.EMAILINTERNO email, p.NOMBREUNIDO nombreCompleto, O.NOMBRE OFICINA, CAST(U.ESTAACTIVO AS BIT) as ESTADO,
U.CODIGO codigoUsuario
FROM FBS_SEGURIDADES.USUARIO_COMPLEMENTO UC
JOIN FBS_SEGURIDADES.USUARIO U ON UC.CODIGOUSUARIO = U.CODIGO
JOIN FBS_PERSONAS.PERSONA P ON UC.SECUENCIALPERSONA = P.SECUENCIAL
JOIN FBS_GENERALES.DIVISION O ON U.SECUENCIALOFICINA = O.SECUENCIAL
where CODIGOUSUARIO = @usuario";

                const string queryRoles = @"select ur.CODIGOROL, r.NOMBRE 
from FBS_SEGURIDADES.USUARIOROL ur
join FBS_SEGURIDADES.ROL r on ur.CODIGOROL = r.CODIGO
where ur.CODIGOUSUARIO = @usuario and ur.ESTAACTIVO = 1";

                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        string user = request.CodigoUsuario.ToString().ToUpper();
                        command.CommandType = CommandType.Text;
                        command.Parameters.Add("@usuario", SqlDbType.VarChar, 20).Value = request.CodigoUsuario.ToUpper().Trim();
                        command.Parameters.Add("@clave", SqlDbType.VarChar, 20).Value = request.Password.Trim();
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    datosUsuario = new DatosUsuario
                                    {
                                        EsValido = await reader.GetFieldValueAsync<bool>(0),
                                        UltimoCambioClave = await reader.GetFieldValueAsync<DateTime>(1),
                                        Email = await reader.GetFieldValueAsync<string>(2),
                                        NombreCompleto = await reader.GetFieldValueAsync<string>(3),
                                        Oficina = await reader.GetFieldValueAsync<string>(4),
                                        Token = token,
                                        Estado = await reader.GetFieldValueAsync<bool>(5),
                                        CodigoUsuario = await reader.GetFieldValueAsync<string>(6),
                                    };
                                }
                            }
                        }
                    }
                    if (datosUsuario != null)
                    {
                        if (datosUsuario.EsValido)
                        {
                            //Consulto los roles del usuario
                            using (var command = new SqlCommand(queryRoles, connection))
                            {
                                command.CommandType = System.Data.CommandType.Text;
                                command.Parameters.AddWithValue("@usuario", request.CodigoUsuario);
                                using (var reader = await command.ExecuteReaderAsync())
                                {
                                    if (reader.HasRows)
                                    {
                                        while (await reader.ReadAsync())
                                        {
                                            var rol = new Roles
                                            {
                                                CodigoRol = await reader.GetFieldValueAsync<string>(0),
                                                Nombre = await reader.GetFieldValueAsync<string>(1),
                                            };
                                            datosUsuario.Roles.Add(rol);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (datosUsuario != null)
                {
                    if (datosUsuario.EsValido)
                    {
                        return datosUsuario;
                    }
                    else
                    {
                        response.Message = "Credenciales no válidas.";
                        response.Code = 400;
                        return response;
                    }
                }
                else
                {
                    response.Message = "Error validando los datos.";
                    response.Code = 400;
                    return response;
                }
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo los datos del usuario: " + request.CodigoUsuario + "en " + nameof(ValidateUser),
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<IEnumerable<dynamic>> GetMenus()
        {
            try
            {
                var menus = await _context.Menuwebs
                           .Include(m => m.Menuwebroles)
                           .ThenInclude(mr => mr.RolecodeNavigation)
                           .Where(m => m.Parentmenuid == null) // Solo menús principales
                           .Select(m => new
                           {
                               m.Id,
                               m.Label,
                               m.Menupath,
                               m.Icon,
                               m.Iconcolor,
                               m.Hassubmenu,
                               m.Issubmenu,
                               m.Parentmenuid,
                               Roles = m.Menuwebroles.Select(mr => new
                               {
                                   CodigoRol = mr.RolecodeNavigation.Codigo,
                                   mr.RolecodeNavigation.Nombre
                               }).ToList(),
                               SubMenus = _context.Menuwebs
                                   .Include(sm => sm.Menuwebroles)
                                   .ThenInclude(smr => smr.RolecodeNavigation)
                                   .Where(sm => sm.Parentmenuid == m.Id) // Submenús del menú actual
                                   .Select(sm => new
                                   {
                                       sm.Id,
                                       sm.Label,
                                       sm.Menupath,
                                       sm.Icon,
                                       sm.Iconcolor,
                                       sm.Hassubmenu,
                                       sm.Issubmenu,
                                       sm.Parentmenuid,
                                       Roles = sm.Menuwebroles.Select(smr => new
                                       {
                                           CodigoRol =  smr.RolecodeNavigation.Codigo,
                                           smr.RolecodeNavigation.Nombre
                                       }).ToList(),
                                       SubMenus = _context.Menuwebs
                                           .Include(nsm => nsm.Menuwebroles)
                                           .ThenInclude(nsmr => nsmr.RolecodeNavigation)
                                           .Where(nsm => nsm.Parentmenuid == sm.Id) // Submenús anidados
                                           .Select(nsm => new
                                           {
                                               nsm.Id,
                                               nsm.Label,
                                               nsm.Menupath,
                                               nsm.Icon,
                                               nsm.Iconcolor,
                                               nsm.Hassubmenu,
                                               nsm.Issubmenu,
                                               nsm.Parentmenuid,
                                               Roles = nsm.Menuwebroles.Select(nsmr => new
                                               {
                                                   CodigoRol=   nsmr.RolecodeNavigation.Codigo,
                                                   nsmr.RolecodeNavigation.Nombre
                                               }).ToList()
                                           }).ToList()
                                   }).ToList()
                           })
                           .ToListAsync();

                return menus;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo los datos del menu en " + nameof(GetMenus),
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<ActionResult<object>> ValidateToken(DtoValidateUserRequest request)
        {
            object jsonReturn;
            try
            {
                // Validar el formato del token
                if (string.IsNullOrWhiteSpace(request.PushToken) || request.PushToken.Split('.').Length != 3)
                {
                    jsonReturn = new
                    {
                        message = "Error: El token no tiene el formato correcto",
                        code = 400
                    };
                    return jsonReturn;
                }

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(masterKey);

                // Validar el token
                var principal = tokenHandler.ValidateToken(request.PushToken, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero // No permitir margen de tiempo para la expiración
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var emailClaim = jwtToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;

                jsonReturn = new
                {
                    isValid = true,
                    email = emailClaim,
                    code = 200
                };
                return jsonReturn;
            }
            catch (SecurityTokenExpiredException)
            {
                jsonReturn = new
                {
                    message = "Error: El token ha expirado",
                    code = 400
                };
                return jsonReturn;
            }
            catch (SecurityTokenInvalidSignatureException)
            {
                jsonReturn = new
                {
                    message = "Error: La firma del token no es valida",
                    code = 400
                };
                return jsonReturn;
            }
            catch (SecurityTokenException ex)
            {
                jsonReturn = new
                {
                    message = $"Error de seguridad: {ex.Message}",
                    code = 400
                };
                return jsonReturn;
            }
            catch (Exception ex)
            {
                jsonReturn = new
                {
                    message = $"Error inesperado: {ex.Message}",
                    code = 500
                };
                return jsonReturn;
            }
        }
    }
}
