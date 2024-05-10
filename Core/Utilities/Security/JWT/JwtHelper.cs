using Core.Entities.Concrete;
using Core.Extentions;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpration);

            // RSA anahtar çifti oluşturun
            using (var rsa = new RSACryptoServiceProvider(2048)) // Anahtar boyutu: 2048 bit
            {
                // Özel anahtarı alın
                var privateKey = rsa.ExportParameters(true);

                // RSA parametrelerinden SecurityKey oluşturun
                var securityKey = new RsaSecurityKey(privateKey);

                // RSA algoritmasını kullanarak signing credentials oluşturun
                var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.RsaSha512);

                // JWT'yi oluşturun
                var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);

                // JWT'yi string formatına dönüştürün
                var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
                var token = jwtSecurityTokenHandler.WriteToken(jwt);

                return new AccessToken
                {
                    Token = token,
                    Expration = _accessTokenExpiration
                };
            }
        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration, // _accessTokenExpiration değişkenini doğru bir şekilde ayarladığınızdan emin olun
                notBefore: _accessTokenExpiration.AddMinutes(-5), // JWT'nin başlangıç tarihini bitiş tarihinden 5 dakika öncesine ayarlayın
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }


        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {

            var claims = new List<Claim>();

            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}