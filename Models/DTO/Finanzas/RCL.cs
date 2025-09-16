namespace GestionesPilarh.Models.DTO.Finanzas
{
    public class Accounts
    {
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public int NumeroCuenta { get; set; } = 0;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Factor { get; set; } = decimal.Zero;
        public string Numeral { get; set; } = string.Empty;
        public int CuentaDolar { get; set; } = 0;
    }

    public class Currency
    {
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public int Numeral { get; set; } = 0;
    }

    public class Record
    {
        public string Descripcion { get; set; } = string.Empty;
        public string Fecha { get; set; } = string.Empty;
        public string Cuenta { get; set; } = string.Empty;
        public int Moneda { get; set; }
        public string Dia { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public string Resumen { get; set; } = string.Empty;
    }

    public class ListaGenerica
    {
        public int Secuencial { get; set; } = 0;
        public string CodigoCuenta { get; set; } = string.Empty;
        public string NombreCuenta { get; set; } = string.Empty;
        public decimal Saldo { get; set; } = decimal.Zero;
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
    public class SaldosCDP
    {
        public DateTime FechaHistorico { get; set; } = DateTime.Now;
        public decimal Saldo { get; set; } = decimal.Zero;
        public decimal Vencimientos { get; set; } = decimal.Zero;
        public decimal Diferencia { get; set; } = decimal.Zero;
        public DateTime DiaFinal { get; set; } = DateTime.Now;
    }
    public class RecuperacionCartera
    {
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Capital { get; set; } = decimal.Zero;
        public decimal Interes { get; set; } = decimal.Zero;
    }
    public class Calendario
    {
        public DateTime Fecha { get; set; } = DateTime.Now;
        public bool EsFeriado { get; set; } = false;
    }
    public class DatosUsuario
    {
        public bool EsValido { get; set; } = false;
        public DateTime UltimoCambioClave { get; set; } = DateTime.Now;
        public string Email { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public string Oficina { get; set; } = string.Empty;
        public bool Estado { get; set; } = false;
        public string Token {  get; set; } = string.Empty;
        public string CodigoUsuario {  get; set; } = string.Empty;
        public List<Roles> Roles { get; set; } = new List<Roles>();
    }
    public class Roles
    {
        public string CodigoRol { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
    }
}
