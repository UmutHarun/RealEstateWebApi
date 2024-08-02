using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace RealEstateWebApi.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseViewModel GenerateToken(GetCheckAppUserViewModel model)
        {
            var claims = new List<Claim>();
            if (!string.IsNullOrWhiteSpace(model.Role))
            {
                claims.Add(new Claim(ClaimTypes.Role, model.Role));
            }
            claims.Add(new Claim(ClaimTypes.NameIdentifier,model.Id.ToString()));
            if (!string.IsNullOrWhiteSpace(model.Username))
            {
                claims.Add(new Claim("Username", model.Username));
            }

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
            var signInCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);
            JwtSecurityToken token = new JwtSecurityToken(JwtTokenDefaults.ValidIssuer, 
                JwtTokenDefaults.ValidAudience, claims, notBefore: DateTime.UtcNow, expireDate, signInCredentials);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return new TokenResponseViewModel(tokenHandler.WriteToken(token),expireDate);
        }
    }
}
