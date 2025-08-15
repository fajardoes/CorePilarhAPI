using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace CorePilarh.Helpers
{
    public class Helpers
    {
        public static string GenerateRandomString()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble() + 1; // Número entre 1 y 2

            // Convierte el número aleatorio a una cadena base-36
            string base36String = ConvertToBase36(randomNumber);

            // Toma los últimos 5 caracteres de la cadena base-36
            return base36String.Length > 6 ? base36String.Substring(base36String.Length - 6) : base36String;
        }
        public static string ConvertToBase36(double number)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            string result = "";

            long intPart = (long)number;
            double fracPart = number - intPart;

            // Convierte la parte entera a base-36
            while (intPart > 0)
            {
                result = chars[(int)(intPart % 36)] + result;
                intPart /= 36;
            }

            // Convierte la parte fraccionaria a base-36
            if (fracPart > 0)
            {
                result += '.';
                int maxDigits = 10; // Limita el número de dígitos fraccionarios
                while (fracPart > 0 && maxDigits-- > 0)
                {
                    fracPart *= 36;
                    result += chars[(int)fracPart];
                    fracPart -= (int)fracPart;
                }
            }

            return result;
        }
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static class TokenHandler
        {
            public static string GenerateToken(string email, string masterKey)
            {
                var keyBytes = Encoding.ASCII.GetBytes(masterKey);
                var claims = new ClaimsIdentity();
                claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, email));
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(
                    [
                        new Claim("email", email.ToString())
                    ]),
                    Expires = DateTime.UtcNow.AddHours(2),
               //     Expires = DateTime.UtcNow.AddMinutes(5),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

                string tokenCreado = tokenHandler.WriteToken(tokenConfig);
                return tokenCreado;
            }
            public static string GetUserIdFromToken(string token, string secretKey)
            {
                try
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(secretKey);

                    // Configura la validación del token
                    var tokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false, // Puedes configurar estos valores según tus necesidades
                        ValidateAudience = false,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                    };

                    // Valida y descomponga el token
                    ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);

                    // Verifica que el token sea un JWT
                    if (validatedToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                    {
                        throw new SecurityTokenException("Token no válido");
                    }
                    // Busca el reclamo "email"
                    var userIdClaim = claimsPrincipal.FindFirst(ClaimTypes.Email);

                    if (userIdClaim != null)
                    {
                        return userIdClaim.Value;
                    }
                    else
                    {
                        throw new SecurityTokenException("Reclamo 'email' no encontrado o no válido en el token.");
                    }
                }
                catch (Exception ex)
                {
                    // Puedes manejar errores de validación aquí, como tokens no válidos o expirados.
                    throw new Exception("Error al validar el token JWT: " + ex.Message);
                }
            }
            public static string GenerateJwtToken(string email, string masterKey, int expirationMinutes)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(masterKey);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Email, email)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(expirationMinutes),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }
    }
}
