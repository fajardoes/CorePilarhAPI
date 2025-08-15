using CorePilarh.Models.DTO;
using CorePilarh.Models.DTO.Finanzas;
using CorePilarh.Services.LoggerAPI;
using Microsoft.Data.SqlClient;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Data;
using System.Reflection.Metadata;

namespace CorePilarh.Services.Finanzas.RCL
{
    public class RatioCoberturaLiquidez : IRatioCoberturaLiquidez
    {
        private readonly IConfiguration _configuration;
        private readonly ILoggerAPI _logger;
        private readonly string _connString;

        public RatioCoberturaLiquidez(IConfiguration configuration, ILoggerAPI logger)
        {
            _configuration = configuration;
            _logger = logger;
            _connString = configuration.GetConnectionString("cadenaSQL") ?? "";
        }

        public async Task<IEnumerable<Record>> ProcessData(DateTime startDate, DateTime endDate)
        {
            List<Accounts> accountsList = new List<Accounts>();
            List<Currency> currencyList = new List<Currency>();
            List<SaldosCDP> saldosCDPsList = new List<SaldosCDP>();
            List<RecuperacionCartera> recuperacionCarteraList = new List<RecuperacionCartera>();
            List<Calendario> calendarList = new List<Calendario>();
            try
            {
                await GetAccounts(accountsList);
                await GetCurrency(currencyList);
                await GetCalendar(calendarList, startDate, endDate);

                var records = new List<Record>();
                await GetSaldosCDP(startDate, endDate, saldosCDPsList);
                await GetRecuperacionCartera(startDate, endDate, recuperacionCarteraList);
                for (var date = startDate; date <= endDate; date = date.AddDays(1))
                {

                    var calendarDate = calendarList.FirstOrDefault(d => d.Fecha == date);
                    var effectiveDate = DateTime.Now;
                    if (calendarDate!= null)
                    {
                         effectiveDate = calendarDate.EsFeriado ? date.AddDays(-1) : date;
                    }
                    else
                    {
                         effectiveDate = date;
                    }
                    foreach (var account in accountsList)
                    {
                        foreach (var currency in currencyList)
                        {
                            var saldo = 0m;
                            if (account.Numeral == "19")
                            {
                                if (currency.Numeral == 1)
                                {
                                    var saldos = saldosCDPsList.Where(f => f.FechaHistorico == effectiveDate).FirstOrDefault();
                                    saldo = saldos?.Diferencia ?? 0m;
                                }
                                else
                                {
                                    saldo = 0m;
                                }
                            }
                            else if (account.Numeral == "29.2")
                            {
                                if (currency.Numeral == 1)
                                {
                                    var saldos = saldosCDPsList.Where(f => f.FechaHistorico == effectiveDate).FirstOrDefault();
                                    saldo = saldos?.Vencimientos ?? 0m;
                                }
                            }
                            else if (account.Numeral == "29.6")
                            {
                                if (currency.Numeral == 1)
                                {
                                    var codigos = new List<int> { 242, 2439902, 2439903, 2439905, 2439906, 2439909 };
                                    saldo = await ObtenerSaldoSuma(effectiveDate, codigos);
                                }
                                else
                                {
                                    saldo = 0m;
                                }
                            }
                            else if (account.Numeral == "29.9")
                            {
                                decimal interesObligaciones = await GetInteresObligaciones(effectiveDate, currency.Numeral == 1 ? 4 : 2);
                                decimal interes218 = await ObtenerSaldoFechaExacta(effectiveDate, account.NumeroCuenta);
                                if (currency.Numeral == 1)
                                {
                                    saldo = interesObligaciones + interes218;
                                }
                                else
                                {
                                    saldo = interesObligaciones;
                                }
                            }
                            else if (account.Numeral == "29.16")
                            {
                                decimal capitalObligaciones = await GetCapitalObligaciones(effectiveDate, currency.Numeral == 1 ? 4 : 2);
                                saldo = capitalObligaciones;
                            }
                            else if (account.Numeral == "29.20")
                            {
                                if (currency.Numeral == 1)
                                {
                                    var codigos = new List<int> { 234, 236 };
                                    saldo = await ObtenerSaldoSuma(effectiveDate, codigos);
                                }
                                else
                                {
                                    saldo = 0m;
                                }
                            }
                            else if (account.Numeral == "30")
                            {
                                if (currency.Numeral == 1)
                                {
                                    var recuperaciones = recuperacionCarteraList.Where(f => f.Fecha == effectiveDate).FirstOrDefault();
                                    saldo = recuperaciones?.Capital ?? 0m;
                                }
                                else
                                {
                                    saldo = 0m;
                                }
                            }
                            else if (account.Numeral == "34")
                            {
                                if (currency.Numeral == 1)
                                {
                                    var recuperaciones = recuperacionCarteraList.Where(f => f.Fecha == effectiveDate).FirstOrDefault();
                                    saldo = recuperaciones?.Interes ?? 0m;
                                }
                                else
                                {
                                    saldo = 0m;
                                }
                            }
                            else
                            {
                                saldo = await ObtenerSaldoFechaExacta(effectiveDate, currency.Numeral == 1 ? account.NumeroCuenta : account.CuentaDolar);
                            }

                            if (saldo > 0)
                            {
                                var record = new Record
                                {
                                    Descripcion = account.Descripcion,
                                    Fecha = date.ToString("yyyyMMdd"),
                                    Cuenta = account.Numeral,
                                    Moneda = currency.Numeral,
                                    Dia = date.ToString("dd"),
                                    Total = saldo,
                                    Resumen = $"16|06|{endDate:yyyyMMdd}|{account.Numeral}|{currency.Numeral}|{date:dd}|{saldo:F2}"
                                };
                                records.Add(record);
                            }
                        }
                    }
                }
                return records;
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error procesando los datos de Ratio Cobertura y Liquidez",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        public async Task ExportToExcel(IEnumerable<Record> records, Stream outputStream)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Records");

                worksheet.Cells[1, 1].Value = "Descripción";
                worksheet.Cells[1, 2].Value = "Fecha";
                worksheet.Cells[1, 3].Value = "Cuenta";
                worksheet.Cells[1, 4].Value = "Moneda";
                worksheet.Cells[1, 5].Value = "Día";
                worksheet.Cells[1, 6].Value = "Total";
                worksheet.Cells[1, 7].Value = "Resumen";

                using (var range = worksheet.Cells[1, 1, 1, 7])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }

                var sortedRecords = records
                    .OrderBy(r => r.Cuenta)
                    .ThenBy(r => int.Parse(r.Dia));

                int row = 2;
                foreach (var record in sortedRecords)
                {
                    worksheet.Cells[row, 1].Value = record.Descripcion;
                    worksheet.Cells[row, 2].Value = record.Fecha;
                    worksheet.Cells[row, 3].Value = record.Cuenta;
                    worksheet.Cells[row, 4].Value = record.Moneda;
                    worksheet.Cells[row, 5].Value = record.Dia;
                    worksheet.Cells[row, 6].Value = record.Total;
                    worksheet.Cells[row, 7].Value = record.Resumen;
                    row++;
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                await package.SaveAsAsync(outputStream);
            }
        }
        public async Task<byte[]> GenerateExcelReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                var records = await ProcessData(startDate, endDate);

                using (var memoryStream = new MemoryStream())
                {
                    await ExportToExcel(records, memoryStream);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error procesando los datos de Ratio Cobertura y Liquidez",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        private async Task<decimal> ObtenerSaldoFechaExacta(DateTime fecha, int codigoCuenta)
        {
            try
            {
                const string query = @"
        SELECT 
            ABS(SC.SALDOINICIAL + SC.TOTALDEBITO - SC.TOTALCREDITO) saldo
        FROM FBS_Pilarh_Produccion.FBS_CONTABILIDADES.SALDOCONTABLE SC
        INNER JOIN FBS_Pilarh_Produccion.FBS_CONTABILIDADES.CUENTACONTABLE CC ON CC.SECUENCIALDIVISION = SC.SECUENCIALCUENTACONTABLE AND CC.ESTAACTIVA = 1
        INNER JOIN FBS_Pilarh_Produccion.FBS_GENERALES.DIVISION D ON D.SECUENCIAL = CC.SECUENCIALDIVISION
        INNER JOIN FBS_Pilarh_Produccion.FBS_GENERALES.NIVELDIVISION ND ON ND.SECUENCIAL = D.SECUENCIALNIVEL
        WHERE 
            SC.SECUENCIALDIVISIONORGANIZACION = 38610
            AND sc.FECHA = @fecha
            AND d.CODIGO = @codigoCuenta
        GROUP BY 
            SC.FECHA, D.CODIGO, D.NOMBRE, sc.SALDOINICIAL, sc.TOTALCREDITO, sc.TOTALDEBITO, sc.SECUENCIAL
        ORDER BY 
            sc.FECHA DESC, d.NOMBRE";

                using (var connection = new SqlConnection(_connString))
                {
                    await connection.OpenAsync();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.Parameters.AddWithValue("@codigoCuenta", codigoCuenta.ToString());

                        var saldo = 0m;
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                saldo = await reader.GetFieldValueAsync<decimal>(0);
                            }
                        }
                        return saldo;
                    }
                }
            }
            catch (Exception ex)
            {
                var dtoLog = new LogsDto
                {
                    Message = "Error procesando los datos de Ratio Cobertura y Liquidez",
                    Level = "Error",
                    Exception = ex.Message,
                };
                await _logger.LogAction(dtoLog);
                throw;
            }
        }
        private async Task<decimal> ObtenerSaldoSuma(DateTime fecha, List<int> listaCuentas)
        {
            const string query = @"
        SELECT 
            ABS(SC.SALDOINICIAL + SC.TOTALDEBITO - SC.TOTALCREDITO) saldo
        FROM FBS_Pilarh_Produccion.FBS_CONTABILIDADES.SALDOCONTABLE SC
        INNER JOIN FBS_Pilarh_Produccion.FBS_CONTABILIDADES.CUENTACONTABLE CC ON CC.SECUENCIALDIVISION = SC.SECUENCIALCUENTACONTABLE AND CC.ESTAACTIVA = 1
        INNER JOIN FBS_Pilarh_Produccion.FBS_GENERALES.DIVISION D ON D.SECUENCIAL = CC.SECUENCIALDIVISION
        INNER JOIN FBS_Pilarh_Produccion.FBS_GENERALES.NIVELDIVISION ND ON ND.SECUENCIAL = D.SECUENCIALNIVEL
        WHERE 
            SC.SECUENCIALDIVISIONORGANIZACION = 38610
            AND sc.FECHA = @fecha
            AND d.CODIGO IN (SELECT Codigo from @CodigosCuenta)
        GROUP BY 
            SC.FECHA, D.CODIGO, D.NOMBRE, sc.SALDOINICIAL, sc.TOTALCREDITO, sc.TOTALDEBITO, sc.SECUENCIAL
        ORDER BY 
            sc.FECHA DESC, d.NOMBRE";
            using (var connection = new SqlConnection(_connString))
            {
                await connection.OpenAsync();
                var table = new DataTable();
                table.Columns.Add("Codigo", typeof(string));
                foreach (var cuenta in listaCuentas)
                {
                    table.Rows.Add(cuenta.ToString());
                }

                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@fecha", fecha);
                    var parameter = command.Parameters.AddWithValue("@CodigosCuenta", table);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "dbo.ListaCodigos";
                    decimal saldo = 0m;
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                saldo += await reader.GetFieldValueAsync<decimal>(0);
                            }
                        }
                    }
                    return saldo;
                }
            }
        }
        private async Task GetSaldosCDP(DateTime startDate, DateTime endDate, List<SaldosCDP> saldosCDPsList)
        {
            const string spName = "CNBS.ObtenerSaldosCDP";

            using (var connection = new SqlConnection(_connString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(spName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FECHA_I", startDate);
                    command.Parameters.AddWithValue("@FECHA_F", endDate);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                saldosCDPsList.Add(new SaldosCDP
                                {
                                    FechaHistorico = await reader.GetFieldValueAsync<DateTime>(0),
                                    Saldo = await reader.GetFieldValueAsync<decimal>(1),
                                    Vencimientos = await reader.GetFieldValueAsync<decimal>(2),
                                    Diferencia = await reader.GetFieldValueAsync<decimal>(3),
                                    DiaFinal = await reader.GetFieldValueAsync<DateTime>(4)
                                });
                            }
                        }
                    }
                }
            }
        }
        private async Task<decimal> GetInteresObligaciones(DateTime date, int moneda)
        {
            const string spName = "CNBS.ObtenerProximosPagosObligaciones";

            using (var connection = new SqlConnection(_connString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FECHA", date);
                    command.Parameters.AddWithValue("@SECMONEDA", moneda);
                    decimal saldo = 0m;
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                saldo += await reader.GetFieldValueAsync<decimal>(5);
                            }
                        }
                    }
                    return saldo;
                }
            }
        }
        private async Task<decimal> GetCapitalObligaciones(DateTime date, int moneda)
        {
            const string spName = "CNBS.ObtenerProximosPagosObligaciones";

            using (var connection = new SqlConnection(_connString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FECHA", date);
                    command.Parameters.AddWithValue("@SECMONEDA", moneda);
                    decimal saldo = 0m;
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                saldo += await reader.GetFieldValueAsync<decimal>(4);
                            }
                        }
                    }
                    return saldo;
                }
            }
        }
        private async Task GetRecuperacionCartera(DateTime startDate, DateTime endDate, List<RecuperacionCartera> recuperacionCarteraList)
        {
            const string spName = "CNBS.RecuperacionCartera";

            using (var connection = new SqlConnection(_connString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(spName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = 260;
                    command.Parameters.AddWithValue("@Fecha_I", startDate);
                    command.Parameters.AddWithValue("@Fecha_F", endDate);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                recuperacionCarteraList.Add(new RecuperacionCartera
                                {
                                    Fecha = await reader.GetFieldValueAsync<DateTime>(0),
                                    Capital = await reader.GetFieldValueAsync<decimal>(1),
                                    Interes = await reader.GetFieldValueAsync<decimal>(2),
                                });
                            }
                        }
                    }
                }
            }
        }
        private async Task GetAccounts(List<Accounts> accountsList)
        {
            const string query = @"select id, nombre, numeroCuenta, descripcion, factor, numeral, cuentaDolar from CNBS.RCL_CUENTAS";

            using (var connection = new SqlConnection(_connString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                accountsList.Add(new Accounts
                                {
                                    Id = await reader.GetFieldValueAsync<int>(0),
                                    Nombre = await reader.GetFieldValueAsync<string>(1),
                                    NumeroCuenta = await reader.GetFieldValueAsync<int>(2),
                                    Descripcion = await reader.GetFieldValueAsync<string>(3),
                                    Factor = await reader.GetFieldValueAsync<decimal>(4),
                                    Numeral = await reader.GetFieldValueAsync<string>(5),
                                    CuentaDolar = await reader.GetFieldValueAsync<int>(6),
                                });
                            }
                        }
                    }
                }
            }
        }
        private async Task GetCalendar(List<Calendario> calendarList, DateTime startDate, DateTime endDate)
        {
            const string query = @"select FECHASISTEMA, ESFERIADO from FBS_GENERALES.CALENDARIO WHERE FECHASISTEMA BETWEEN @FECHAINICIO AND @FECHAFIN";

            using (var connection = new SqlConnection(_connString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@FECHAINICIO", startDate);
                    command.Parameters.AddWithValue("@FECHAFIN", endDate);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                calendarList.Add(new Calendario
                                {
                                    Fecha = await reader.GetFieldValueAsync<DateTime>(0),
                                    EsFeriado = await reader.GetFieldValueAsync<bool>(1),
                                });
                            }
                        }
                    }
                }
            }
        }
        private async Task GetCurrency(List<Currency> currencyList)
        {
            const string query = @"select id, nombre, numeral from CNBS.MONEDA";

            using (var connection = new SqlConnection(_connString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                currencyList.Add(new Currency
                                {
                                    Id = await reader.GetFieldValueAsync<int>(0),
                                    Nombre = await reader.GetFieldValueAsync<string>(1),
                                    Numeral = await reader.GetFieldValueAsync<int>(2),
                                });
                            }
                        }
                    }
                }
            }
        }

    }
}
