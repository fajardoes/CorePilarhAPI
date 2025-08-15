using CorePilarh.Models.DTO;
using CorePilarh.Models.DTO.ActivosFijos;
using CorePilarh.Services.LoggerAPI;
using Microsoft.Data.SqlClient;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using CorePilarh.Models.ActivosFijos;
using Microsoft.EntityFrameworkCore;
using CorePilarh.Models.Generales;
using CorePilarh.Models;
using System.Data;

namespace CorePilarh.Services.ActivosFijos
{
    public class ActivosFijos : IActivosFijos
    {
        private readonly IConfiguration _configuration;
        private readonly ILoggerAPI _logger;
        private readonly string _connString;
        private readonly ActivosFijosContext _context;
        private readonly GeneralesContext _generalesContext;
        private readonly FbsPilarhProduccionContext _seguridadContext;

        public ActivosFijos(IConfiguration configuration, ILoggerAPI logger, ActivosFijosContext context, GeneralesContext generalesContext, FbsPilarhProduccionContext seguridadContext)
        {
            _configuration = configuration;
            _logger = logger;
            _connString = configuration.GetConnectionString("cadenaSQL") ?? "";
            _context = context;
            _generalesContext = generalesContext;
            _seguridadContext = seguridadContext;
        }
        #region Listas
        public async Task<IEnumerable<dynamic>> GetAFStructure(int SecTipoDivision)
        {
            List<EstructuraActivosDto> lista = new List<EstructuraActivosDto>();
            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    var query = @"SELECT RUBRO.SECUENCIAL secRubro,   RUBRO.CODIGO codigoRubro, RUBRO.NOMBRE nombreRubro, item.SECUENCIAL secItem, ITEM.CODIGO codigoItem, 
ITEM.NOMBRE nombreItem, 
SUBITEM.SECUENCIAL secSubItem,
SUBITEM.CODIGO codigoSubItem,
SUBITEM.NOMBRE nombreSubItem
			FROM FBS_GENERALES.DIVISION SUBITEM
			INNER JOIN FBS_GENERALES.PADREDIVISION PADRESUBITEM ON SUBITEM.SECUENCIAL = PADRESUBITEM.SECUENCIALDIVISION
			INNER JOIN FBS_GENERALES.DIVISION ITEM ON PADRESUBITEM.SECUENCIALDIVISIONPADRE = ITEM.SECUENCIAL
			INNER JOIN FBS_GENERALES.PADREDIVISION PADREITEM ON ITEM.SECUENCIAL = PADREITEM.SECUENCIALDIVISION
			INNER JOIN FBS_GENERALES.DIVISION RUBRO ON RUBRO.SECUENCIAL = PADREITEM.SECUENCIALDIVISIONPADRE
            INNER JOIN FBS_GENERALES.NIVELDIVISION ND ON SUBITEM.SECUENCIALNIVEL = ND.SECUENCIAL
           WHERE ND.SECUENCIALTIPODIVISION = @SecTipoDivision
           ORDER BY ND.NIVEL";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@SecTipoDivision", SecTipoDivision);
                        command.CommandType = System.Data.CommandType.Text;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    lista.Add(new EstructuraActivosDto()
                                    {
                                        SecRubro = await reader.GetFieldValueAsync<int>(0),
                                        CodigoRubro = await reader.GetFieldValueAsync<string>(1),
                                        NombreRubro = await reader.GetFieldValueAsync<string>(2),
                                        SecItem = await reader.GetFieldValueAsync<int>(3),
                                        CodigoItem = await reader.GetFieldValueAsync<string>(4),
                                        NombreItem = await reader.GetFieldValueAsync<string>(5),
                                        SecSubItem = await reader.GetFieldValueAsync<int>(6),
                                        CodigoSubItem = await reader.GetFieldValueAsync<string>(7),
                                        NombreSubItem = await reader.GetFieldValueAsync<string>(8)
                                    });
                                }
                            }
                        }
                        command.Parameters.Clear();
                    }
                }

                var groupedData = lista
                    .GroupBy(r => new { r.SecRubro, r.CodigoRubro, r.NombreRubro })
                    .Select(rubroGroup => new Rubro
                    {
                        SecRubro = rubroGroup.Key.SecRubro,
                        CodigoRubro = rubroGroup.Key.CodigoRubro,
                        NombreRubro = rubroGroup.Key.NombreRubro,
                        Items = rubroGroup
                            .GroupBy(i => new { i.SecItem, i.CodigoItem, i.NombreItem })
                            .Select(itemGroup => new Item
                            {
                                SecItem = itemGroup.Key.SecItem,
                                CodigoItem = itemGroup.Key.CodigoItem,
                                NombreItem = itemGroup.Key.NombreItem,
                                SubItems = itemGroup
                                    .Select(subItem => new SubItem
                                    {
                                        SecSubItem = subItem.SecSubItem,
                                        CodigoSubItem = subItem.CodigoSubItem,
                                        NombreSubItem = subItem.NombreSubItem
                                    })
                                    .ToList()
                            })
                            .ToList()
                    })
                    .ToList();


                return groupedData; ;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo la estructura de Activos Fijos",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        //        public async Task<IEnumerable<dynamic>> ObtenerPersonasResponsables(string filtro)
        //        {
        //            List<DtoPersonaResponsable> list = new List<DtoPersonaResponsable>();

        //            try
        //            {
        //                using (var connection = new SqlConnection(_connString))
        //                {
        //                    await connection.OpenAsync();
        //                    var query = @"SELECT  P.SECUENCIAL SECUENCIALPERSONA, OD.SECUENCIAL SECUENCIALOFICINADEPARTAMENTO,OD.SECUENCIALDEPARTAMENTO, OD.SECUENCIALOFICINA, P.IDENTIFICACION, P.NOMBREUNIDO, DIV.NOMBRE OFICINA, D.NOMBRE DEPARTAMENTO
        //FROM FBS_ACTIVOSFIJOS.PERSONA_RESPONSABLE 
        //INNER JOIN FBS_ORGANIZACIONES.OFICINADEPARTAMENTO OD ON PERSONA_RESPONSABLE.SECUENCIALOFICINADEPARTAMENTO = OD.SECUENCIAL 
        //INNER JOIN FBS_ORGANIZACIONES.DEPARTAMENTO D  ON OD.SECUENCIALDEPARTAMENTO = D.SECUENCIAL
        //INNER JOIN FBS_ORGANIZACIONES.OFICINA O ON OD.SECUENCIALOFICINA = O.SECUENCIALDIVISION 
        //INNER JOIN FBS_GENERALES.DIVISION DIV ON O.SECUENCIALDIVISION = DIV.SECUENCIAL
        //INNER JOIN FBS_PERSONAS.PERSONA P ON PERSONA_RESPONSABLE.SECUENCIALPERSONA = P.SECUENCIAL 
        //WHERE 
        //P.NOMBREUNIDO >= @nombre  
        //AND PERSONA_RESPONSABLE.ESTAACTIVO = @estaActivo  
        //ORDER BY P.NOMBREUNIDO ASC";
        //                    using (var command = new SqlCommand(query, connection))
        //                    {
        //                        command.Parameters.Clear();
        //                        command.Parameters.AddWithValue("@nombre", filtro);
        //                        command.Parameters.AddWithValue("@estaActivo", 1);
        //                        command.CommandType = System.Data.CommandType.Text;
        //                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
        //                        {
        //                            if (reader.HasRows)
        //                            {
        //                                while (await reader.ReadAsync())
        //                                {
        //                                    list.Add(new DtoPersonaResponsable()
        //                                    {
        //                                        SecuencialPersona = await reader.GetFieldValueAsync<int>(0),
        //                                        SecuencialOficinaDpto = await reader.GetFieldValueAsync<int>(1),
        //                                        SecuencialDpto = await reader.GetFieldValueAsync<int>(2),
        //                                        SecuencialOficina = await reader.GetFieldValueAsync<int>(3),
        //                                        Identificacion = await reader.GetFieldValueAsync<string>(4),
        //                                        NombreCompleto = await reader.GetFieldValueAsync<string>(5),
        //                                        Oficina = await reader.GetFieldValueAsync<string>(6),
        //                                        Dpto = await reader.GetFieldValueAsync<string>(7)
        //                                    });
        //                                }
        //                            }
        //                        }
        //                        command.Parameters.Clear();
        //                    }
        //                }
        //                return list;
        //            }
        //            catch (Exception ex)
        //            {
        //                var dtoLog = new LogsDto
        //                {
        //                    Message = "Error obteniendo las personas responsables",
        //                    Level = "Error",
        //                    Exception = ex.Message,
        //                };
        //                await _logger.LogAction(dtoLog);
        //                throw;
        //            }

        //        }
        public async Task<IEnumerable<dynamic>> ObtenerOficinas()
        {
            List<DtoOficina> list = new List<DtoOficina>();

            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    var query = @"SELECT O.SECUENCIALDIVISION, D.NOMBRE OFICINA 
FROM FBS_ORGANIZACIONES.OFICINA O
INNER JOIN FBS_GENERALES.DIVISION D ON O.SECUENCIALDIVISION = D.SECUENCIAL
WHERE O.ESTAACTIVA = @estaActivo
ORDER BY CIUDAD ASC";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@estaActivo", 1);
                        command.CommandType = System.Data.CommandType.Text;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    list.Add(new DtoOficina()
                                    {
                                        SecuencialOficina = await reader.GetFieldValueAsync<int>(0),
                                        Oficina = await reader.GetFieldValueAsync<string>(1),
                                    });
                                }
                            }
                        }
                        command.Parameters.Clear();
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo las personas responsables",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }

        }
        public async Task<IEnumerable<dynamic>> ObtenerPersonasResponsables(string secuencialOficina)
        {
            List<DtoPersonaResponsable> list = new List<DtoPersonaResponsable>();
            List<string> secuencialOficinaList = new List<string>();
            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    string baseQuery = "";
                    var query = @"SELECT pr.SECUENCIALPERSONA, p.NOMBREUNIDO
 FROM FBS_ACTIVOSFIJOS.PERSONA_RESPONSABLE PR
INNER JOIN FBS_ORGANIZACIONES.OFICINADEPARTAMENTO OD ON PR.SECUENCIALOFICINADEPARTAMENTO = OD.SECUENCIAL
INNER JOIN FBS_PERSONAS.PERSONA P ON PR.SECUENCIALPERSONA = P.SECUENCIAL
WHERE PR.ESTAACTIVO = @estaActivo";
                    if (secuencialOficina != "N/A")
                    {
                        secuencialOficinaList = secuencialOficina.Split(',').ToList();
                        query += " AND OD.SECUENCIALOFICINA IN (" + string.Join(",", secuencialOficinaList.Select((_, i) => "@SecuencialOficina" + i)) + ")";
                    }
                    query += " ORDER BY P.NOMBREUNIDO ASC";
                    baseQuery = query;
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@estaActivo", 1);
                        if (secuencialOficina != "N/A")
                        {
                            for (int i = 0; i < secuencialOficinaList.Count; i++)
                            {
                                command.Parameters.AddWithValue("@SecuencialOficina" + i, secuencialOficinaList[i]);
                            }
                        }
                        command.CommandType = System.Data.CommandType.Text;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    list.Add(new DtoPersonaResponsable()
                                    {
                                        SecuencialPersona = await reader.GetFieldValueAsync<int>(0),
                                        NombreCompleto = await reader.GetFieldValueAsync<string>(1),
                                    });
                                }
                            }
                        }
                        command.Parameters.Clear();
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo las personas responsables",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }

        }
        public async Task<IEnumerable<dynamic>> ObtenerAreas(int SecOficina)
        {
            List<DtoAreas> list = new List<DtoAreas>();

            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    var query = @"SELECT OA.SECUENCIAL SECUENCIALOFICINAAREA, OA.SECUENCIALOFICINA,A.SECUENCIAL SECUENCIALAREA ,A.CODIGO CODIGOAREA, A.NOMBRE AREA
FROM FBS_ORGANIZACIONES.OFICINAAREA  OA
INNER JOIN FBS_ORGANIZACIONES.AREA A ON OA.SECUENCIALAREA = A.SECUENCIAL
WHERE OA.SECUENCIALOFICINA = @SECUENCIALOFICINA AND OA.ESTAACTIVA = @ESTAACTIVA 
ORDER BY A.NOMBRE ASC";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@SECUENCIALOFICINA", SecOficina);
                        command.Parameters.AddWithValue("@ESTAACTIVA", 1);
                        command.CommandType = System.Data.CommandType.Text;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    list.Add(new DtoAreas()
                                    {
                                        SecuencialOficinaArea = await reader.GetFieldValueAsync<int>(0),
                                        SecuencialOficina = await reader.GetFieldValueAsync<int>(1),
                                        SecuencialArea = await reader.GetFieldValueAsync<int>(2),
                                        CodigoArea = await reader.GetFieldValueAsync<string>(3),
                                        NombreArea = await reader.GetFieldValueAsync<string>(4)
                                    });
                                }
                            }
                        }
                        command.Parameters.Clear();
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo las areas",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<IEnumerable<dynamic>> ObtenerEstadoActivo()
        {
            List<DtoEstadoActivo> list = new List<DtoEstadoActivo>();

            try
            {
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    var query = @"SELECT EF.CODIGO, EF.NOMBRE, EF.ESTAACTIVO, EF.NUMEROVERIFICADOR 
FROM  FBS_ACTIVOSFIJOS.ESTADOFISICOACTIVO  EF
WHERE EF.ESTAACTIVO = @ESTAACTIVO  
ORDER BY EF.CODIGO";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ESTAACTIVO", 1);
                        command.CommandType = System.Data.CommandType.Text;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    list.Add(new DtoEstadoActivo()
                                    {
                                        Codigo = await reader.GetFieldValueAsync<string>(0),
                                        Nombre = await reader.GetFieldValueAsync<string>(1),
                                        EstaActivo = await reader.GetFieldValueAsync<bool>(2),
                                    });
                                }
                            }
                        }
                        command.Parameters.Clear();
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo los estados del activo",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<IEnumerable<dynamic>> ObtenerActivosFijos(string secuencialResponsable)
        {
            List<DtoActivoListado> list = new List<DtoActivoListado>();
            try
            {
                List<string> secuencialResponsableList = new List<string>();
                string baseQuery = "";
                string query = @"SELECT TOP 200 a.SECUENCIAL, a.CODIGOCOMPUESTO, a.FECHAADQUISICION, a.COSTO, a.DESCRIPCION, ea.NOMBRE estado, ef.NOMBRE estadoFisico,  div.NOMBRE oficina,
d.NOMBRE departamento, p.NOMBREUNIDO responsable 
from FBS_ACTIVOSFIJOS.ACTIVO a
inner join FBS_ACTIVOSFIJOS.ESTADOACTIVO ea on a.CODIGOESTADOACTIVO = ea.CODIGO
inner join FBS_ACTIVOSFIJOS.ESTADOFISICOACTIVO ef on a.CODIGOESTADOFISICOACTIVO = ef.CODIGO
inner join FBS_ORGANIZACIONES.OFICINADEPARTAMENTO od on a.SECUENCIALOFICINADEPARTAMENTO = od.SECUENCIAL
inner join FBS_ORGANIZACIONES.DEPARTAMENTO d on od.SECUENCIALDEPARTAMENTO = d.SECUENCIAL
inner join FBS_GENERALES.DIVISION div on od.SECUENCIALOFICINA = div.SECUENCIAL
inner join FBS_ACTIVOSFIJOS.PERSONA_RESPONSABLE pr on a.SECUENCIALPERSONARESPONSABLE = pr.SECUENCIALPERSONA
inner join FBS_PERSONAS.PERSONA p on pr.SECUENCIALPERSONA = p.SECUENCIAL ";
                if (secuencialResponsable != "N/A")
                {
                    secuencialResponsableList = secuencialResponsable.Split(',').ToList();
                    query += "where a.SECUENCIALPERSONARESPONSABLE IN (" + string.Join(",", secuencialResponsableList.Select((_, i) => "@SecuencialOficina" + i)) + ")";
                }

                query += " order by a.FECHAADQUISICION desc";
                baseQuery = query;

                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    using (var command = new SqlCommand(baseQuery, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Parameters.Clear();
                        if (secuencialResponsable != "N/A")
                        {
                            for (int i = 0; i < secuencialResponsableList.Count; i++)
                            {
                                command.Parameters.AddWithValue("@SecuencialOficina" + i, secuencialResponsableList[i]);
                            }
                        }
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    list.Add(new DtoActivoListado()
                                    {
                                        Secuencial = await reader.GetFieldValueAsync<int>(0),
                                        CodigoCompuesto = await reader.GetFieldValueAsync<string>(1),
                                        FechaAdquisicion = await reader.GetFieldValueAsync<DateTime>(2),
                                        Costo = await reader.GetFieldValueAsync<decimal>(3),
                                        Descripcion = await reader.GetFieldValueAsync<string>(4),
                                        Estado = await reader.GetFieldValueAsync<string>(5),
                                        EstadoFisico = await reader.GetFieldValueAsync<string>(6),
                                        Oficina = await reader.GetFieldValueAsync<string>(7),
                                        Departamento = await reader.GetFieldValueAsync<string>(8),
                                        Responsable = await reader.GetFieldValueAsync<string>(9),
                                    });
                                }
                            }
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo la lista de Activos Fijos",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<IEnumerable<dynamic>> ObtenerControlActivos(List<int>? oficinasID = null, DateTime? fecha = null)
        {
            var response = new DtoActivoRespuesta();
            try
            {
                var query = _context.Controls.Include(c => c.SecuencialoficinaNavigation).AsQueryable();

                if (oficinasID != null && oficinasID.Any())
                {
                    query = query.Where(c => oficinasID.Contains(c.Secuencialoficina));
                }

                if (fecha.HasValue)
                {
                    query = query.Where(c => c.Fecha.Date == fecha.Value.Date);
                }

                var list = await query
                    .OrderByDescending(c => c.Fecha)
                    .Take(40)
                        .Select(c => new
                        {
                            c.Id,
                            c.Fecha,
                            c.Descripcion,
                            c.Estado,
                            c.Secuencialoficina,
                            c.Fechacliente,
                            c.Codigousuario,
                            c.Activo,
                            OficinaNombre = c.SecuencialoficinaNavigation.Ciudad
                        })
                    .ToListAsync();
                return list;
            }

            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo los controles de activos",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<IEnumerable<dynamic>> ObtenerControlActivosByEstado(int estado)
        {
            var response = new DtoActivoRespuesta();
            try
            {
                var query = _context.Controls.Include(c => c.SecuencialoficinaNavigation).AsQueryable();
                query = query.Where(c => c.Estado == estado);
                var list = await query
                    .OrderByDescending(c => c.Fecha)
                    .Take(20)
                        .Select(c => new
                        {
                            c.Id,
                            c.Fecha,
                            c.Descripcion,
                            c.Estado,
                            c.Secuencialoficina,
                            c.Fechacliente,
                            c.Codigousuario,
                            c.Activo,
                            OficinaNombre = c.SecuencialoficinaNavigation.Ciudad
                        })
                    .ToListAsync();
                return list;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo los controles de activos",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<IEnumerable<dynamic>> ObtenerActivoByCode(string code)
        {
            try
            {
                var query = _context.Activos.AsQueryable();
                var list = await query.Select(a => new
                {
                    a.Secuencial,
                    a.Costo,
                    a.Descripcion,
                    a.Codigocompuesto
                }).Where(c => c.Codigocompuesto == code).ToListAsync();
                return list;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo la lista de menus " + nameof(ObtenerActivoByCode),
                    Level = "Error",
                    Exception = "Error: " + ex?.InnerException?.Message.ToString()
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<IEnumerable<dynamic>> ObtenerControlDetalle(int controlId)
        {
            try
            {
                var query = _context.Controldetalles
                    .Include(a => a.SecuencialactivoNavigation)
                    .AsQueryable();
                var list = await query.Where(c => c.Idcontrol == controlId).ToListAsync();
                return list;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo el control detalle " + nameof(ObtenerControlDetalle),
                    Level = "Error",
                    Exception = "Error: " + ex?.InnerException?.Message.ToString()
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        #endregion

        #region Logica
        public async Task<ActionResult<object>> GuardarActivo(DtoActivo request)
        {
            bool permiteIngreso = await PermiteIngreso(request.CodigoUsuario);
            if (!permiteIngreso)
            {
                var response = new DtoActivoRespuesta();
                response.Message = "El sistema se encuentra en mantenimiento, no es posible realizar transacciones";
                response.Code = 503;
                var dtoLog = new LogsDto
                {
                    Message = "No se puede realizar la transacción porque el sistema esta en mantenimiento GuardarActivo",
                    Level = "Warning",
                    Exception = ""
                };
                await _logger.LogAction(dtoLog);
                return response;
            }

            DateTime fechaSistema = await ObtenerFechaSistema(request.CodigoUsuario);
            if (fechaSistema != request.FechaSistema)
            {
                var response = new DtoActivoRespuesta();
                response.Message = "La fecha del sistema ha cambiado, debe iniciar sesión nuevamente";
                response.Code = 401;
                var dtoLog = new LogsDto
                {
                    Message = "La fecha del sistema ha cambiado, debe iniciar sesión nuevamente",
                    Level = "Warning",
                    Exception = ""
                };
                await _logger.LogAction(dtoLog);
                return response;
            }

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                string codigoActivo = await GeneraCodigoActivo(request.SecuencialDivisionEstructuraActivoFijo);
                int ultimoSecuencial = await ObtenerUltimoSecuencial(request.SecuencialDivisionEstructuraActivoFijo);
                int siguienteSecuencial = 0;
                if (ultimoSecuencial > 0)
                    siguienteSecuencial += ultimoSecuencial + 1;
                else
                    siguienteSecuencial += 1;


                var activo = new Activo
                {
                    Secuencialdivestructuraactfijo = request.SecuencialDivisionEstructuraActivoFijo,
                    Numerosecuencial = siguienteSecuencial,
                    Fechaadquisicion = request.FechaAdquisicion,
                    Costo = request.Costo,
                    Descripcion = request.Descripcion,
                    Secuencialpersonaresponsable = request.SecuencialPersonaResponsable,
                    Secuencialoficinadepartamento = request.SecuencialOficinaDepartamento,
                    Secuencialmoneda = request.SecuencialMoneda,
                    Codigousuario = request.CodigoUsuario,
                    Fechamaquina = request.FechaMaquina,
                    Fechasistema = request.FechaSistema,
                    Codigocompuesto = codigoActivo,
                    Codigoestadoactivo = request.CodigoEstadoActivo,
                    Codigoestadofisicoactivo = request.CodigoEstadoFisicoActivo,
                    Numeroverificador = 1,
                    Esactivodiferido = request.EsActivoDiferido,
                    Eseventual = request.EsEventual
                };
                _context.Activos.Add(activo);
                await _context.SaveChangesAsync();

                if (request.Attachments != null)
                {
                    if (request.Attachments.Count > 0)
                    {
                        foreach (var attachment in request.Attachments)
                        {
                            var activoAttachment = new Activoadjunto
                            {
                                Secuencialactivo = activo.Secuencial,
                                Filename = attachment.FileName,
                                Contenttype = attachment.ContentType,
                                Filedata = attachment.FileData,
                                Fecharegistro = attachment.FechaRegistro,
                            };
                            _context.Activoadjuntos.Add(activoAttachment);
                        }
                    }
                }
                await _context.SaveChangesAsync();



                var activoArea = new ActivoArea
                {
                    Secuencialactivo = activo.Secuencial,
                    Secuencialarea = request.SecuencialArea,
                    Estaactivo = true,
                    Numeroverificador = 1
                };
                _context.ActivoAreas.Add(activoArea);
                await _context.SaveChangesAsync();

                var activoOficinaProrrateo = new Activooficinaprorrateo
                {
                    Secuencialactivo = activo.Secuencial,
                    Secuencialoficina = request.SecuencialOficina,
                    Porcentaje = 100,
                    Estaactivo = true,
                    Numeroverificador = 1
                };
                _context.Activooficinaprorrateos.Add(activoOficinaProrrateo);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();

                var response = new DtoActivoRespuesta();
                response.Message = "Se registró con éxito";
                response.Code = 200;
                var dtoLog = new LogsDto
                {
                    Message = "Nuevo activo registrado por " + request.CodigoUsuario + " con seceuencial " + activo.Secuencial,
                    Level = "Information",
                    Exception = ""
                };
                await _logger.LogAction(dtoLog);
                return response;

            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                var dtoLog = new LogsDto
                {
                    Message = "Error guardando el activo",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<ActionResult<dynamic>> GuardarControlActivo(DtoActivoControl request)
        {
            var response = new DtoActivoRespuesta();
            var controlActivo = await _context.Controls.FirstOrDefaultAsync(c => c.Fecha == request.Fecha & c.Secuencialoficina == request.SecuencialOficina);
            if (controlActivo != null)
            {
                response.Message = "El registro con fecha y oficina ya esta ingresado en el sistema.";
                response.Code = 400;

                return response;
            }
            try
            {
                var control = new Control
                {
                    Fecha = request.Fecha,
                    Descripcion = request.Descripcion,
                    Estado = request.Estado,
                    Secuencialoficina = request.SecuencialOficina,
                    Fechacliente = DateTime.Now,
                    Codigousuario = request.CodigoUsuario,
                    Activo = request.Activo,
                };
                _context.Controls.Add(control);
                await _context.SaveChangesAsync();
                response.Message = "Se registró con éxito";
                response.Code = 200;
                return response;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error guardando el registro",
                    Level = "Error",
                    Exception = "Error: " + ex?.InnerException?.Message.ToString(),
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<ActionResult<dynamic>> ActualizaControlActivo(DtoActivoControl request)
        {
            var response = new DtoActivoRespuesta();
            var controlActivo = await _context.Controls.FirstOrDefaultAsync(c => c.Fecha == request.Fecha & c.Secuencialoficina == request.SecuencialOficina & c.Id != request.Id);
            if (controlActivo != null)
            {
                response.Message = "El registro con la misma fecha y oficina ya esta ingresado en el sistema.";
                response.Code = 400;

                return response;
            }
            try
            {
                var control = await _context.Controls.FindAsync(request.Id);
                if (control != null)
                {
                    control.Fecha = request.Fecha;
                    control.Descripcion = request.Descripcion;
                    control.Estado = request.Estado;
                    control.Secuencialoficina = request.SecuencialOficina;
                    control.Codigousuario = request.CodigoUsuario;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    response.Message = "No se encuentra el control de activo";
                    response.Code = 400;
                    return response;
                }

                response.Message = "Se modificó con éxito";
                response.Code = 200;
                return response;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error actualizando el registro",
                    Level = "Error",
                    Exception = "Error: " + ex?.InnerException?.Message.ToString(),
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<ActionResult<dynamic>> ActualizaEstadoControlActivo(int controlId, int estado)
        {
            var response = new DtoActivoRespuesta();
            try
            {
                var control = await _context.Controls.FindAsync(controlId);
                if (control != null)
                {
                    control.Estado = estado;
                    await _context.SaveChangesAsync();
                }
                response.Message = "Se modificó con éxito";
                response.Code = 200;
                return response;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error actualizando el registro",
                    Level = "Error",
                    Exception = "Error: " + ex?.InnerException?.Message.ToString(),
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<ActionResult<dynamic>> GuardarControlActivoDetalle(DtoActivoControlDetalle request)
        {
            var response = new DtoActivoRespuesta();
            var controlActivoDetalle = await _context.Controldetalles.FirstOrDefaultAsync(c => c.Idcontrol == request.IdControl & c.Secuencialactivo == request.SecuencialActivo);
            if (controlActivoDetalle != null)
            {
                response.Message = "El registro ya esta en el control seleccionado.";
                response.Code = 400;

                return response;
            }
            try
            {
                var controlDetalle = new Controldetalle
                {
                    Idcontrol = request.IdControl,
                    Secuencialactivo = request.SecuencialActivo,
                    Descripcion = request.Descripcion,
                    Codigousuario = request.CodigoUsuario,
                    Activo = request.Activo,
                    Fechacliente = DateTime.Now,
                };
                _context.Controldetalles.Add(controlDetalle);
                await _context.SaveChangesAsync();
                response.Message = "Se registró con éxito";
                response.Code = 200;
                return response;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error guardando el registro",
                    Level = "Error",
                    Exception = "Error: " + ex?.InnerException?.Message.ToString(),
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<ActionResult<object>> EliminaControlActivoDetalle(int activoDetalleId)
        {
            var response = new ResponseDto();
            try
            {
                var controlDetalle = await _context.Controldetalles.FindAsync(activoDetalleId);

                _context.Controldetalles.Remove(controlDetalle);
                await _context.SaveChangesAsync();
                response.Message = "Se eliminó con éxito";
                response.Code = 200;
                return response;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error eliminando el menu",
                    Level = "Error",
                    Exception = "Error: " + ex?.InnerException?.Message.ToString(),
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }


        public async Task<string> GeneraCodigoActivo(int? secuencialDivision)
        {
            int ultimoSecuencial = await ObtenerUltimoSecuencial(secuencialDivision ?? 0);
            int siguienteSecuencial = 0;
            if (ultimoSecuencial > 0)
                siguienteSecuencial += ultimoSecuencial + 1;
            else
                siguienteSecuencial += 1;

            string CodigoAcivo = await DevuelveCodigoActivo(secuencialDivision);
            CodigoAcivo += "-" + siguienteSecuencial;

            return CodigoAcivo;
        }
        public async Task<string> DevuelveCodigoActivo(int? secuencialDivision)
        {
            StringBuilder cadena = new StringBuilder("");
            try
            {
                DtoPadreDivision? padreDivision = await ObtenerPadreDivision(secuencialDivision ?? null);
                if (padreDivision?.SecuencialDivisionPadre != 0)
                {
                    cadena.Append(await DevuelveCodigoActivo(padreDivision?.SecuencialDivisionPadre));
                    cadena.Append('-');
                }
                DtoDivision division = await ObtenerDivision(secuencialDivision ?? 0);
                cadena.Append(division.Codigo);
                return cadena.ToString();
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error creando el codigo compuesto del activo",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<DtoPadreDivision?> ObtenerPadreDivision(int? secuencial)
        {
            try
            {
                var padreDivision = await _generalesContext.Padredivisions
                    .Where(pd => pd.Secuencialdivision == secuencial)
                    .Select(pd => new DtoPadreDivision
                    {
                        SecuencialDivision = pd.Secuencialdivision,
                        SecuencialDivisionPadre = pd.Secuencialdivisionpadre,
                        NumeroVerificador = pd.Numeroverificador
                    })
                    .FirstOrDefaultAsync();
                return padreDivision ?? new DtoPadreDivision();
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo el padre division",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<DtoDivision> ObtenerDivision(int secuencial)
        {
            try
            {
                var division = await _generalesContext.Divisions
                    .Where(d => d.Secuencial == secuencial)
                    .Select(d => new DtoDivision
                    {
                        Secuencial = d.Secuencial,
                        SecuencialNivel = d.Secuencialnivel,
                        Codigo = d.Codigo ?? "",
                        Nombre = d.Nombre ?? "",
                        NumeroVerificador = d.Numeroverificador
                    })
                    .FirstOrDefaultAsync();

                return division ?? new DtoDivision();
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo el padre division",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<int> ObtenerUltimoSecuencial(int secuencialActivo)
        {
            try
            {
                var resultado = await _context.Activos
                    .Where(a => a.Secuencialdivestructuraactfijo == secuencialActivo)
                    .MaxAsync(a => (int?)a.Numerosecuencial);

                return resultado ?? 0;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo el ultimo secuencial del activo",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<bool> EsUltimoNivel(int secuencial)
        {
            var estructura = await GetAFStructure(10);
            foreach (var rubro in estructura)
            {
                if (rubro.SecRubro == secuencial)
                {
                    // Si es rubro, es último nivel si no tiene items
                    return rubro.Items.Count == 0;
                }

                foreach (var item in rubro.Items)
                {
                    if (item.SecItem == secuencial)
                    {
                        // Si es item, es último nivel si no tiene subitems
                        return item.SubItems.Count == 0;
                    }

                    foreach (var subitem in item.SubItems)
                    {
                        if (subitem.SecSubItem == secuencial)
                        {
                            // SubItem siempre es último nivel, ya que es el más bajo
                            return true;
                        }
                    }
                }
            }

            // Si no se encuentra el secuencial
            return false;
        }
        public async Task<DateTime> ObtenerFechaSistema(string codigoUsuario)
        {
            try
            {
                const string query = @"
        SELECT TOP 1 CALENDARIO.FECHASISTEMA FROM FBS_GENERALES.CALENDARIO 
WHERE CALENDARIO.SECUENCIALEMPRESA = ( SELECT OFICINA.SECUENCIALEMPRESA 
FROM FBS_ORGANIZACIONES.OFICINA 
WHERE OFICINA.SECUENCIALDIVISION = ( SELECT USUARIO.SECUENCIALOFICINA FROM FBS_SEGURIDADES.USUARIO WHERE USUARIO.CODIGO = @CODIGOUSUARIO ) ) 
AND CALENDARIO.ESTACERRADO = 0 ORDER BY CALENDARIO.FECHASISTEMA ASC ";
                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CODIGOUSUARIO", codigoUsuario);
                        var fecha = DateTime.MinValue;

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                fecha = await reader.GetFieldValueAsync<DateTime>(0);
                            }
                        }
                        return fecha;
                    }
                }
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo la fecha del sistema",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task<bool> PermiteIngreso(string codigoUsuario)
        {
            try
            {
                var resultado = await _seguridadContext.UsuarioComplementos
                    .Where(uc => uc.Codigousuario == codigoUsuario).FirstOrDefaultAsync();

                return resultado?.Permiteingresosistema ?? false;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error obteniendo permite ingreso",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }

        #endregion
    }
}
