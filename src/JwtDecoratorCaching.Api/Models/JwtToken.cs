using JwtDecoratorCaching.Api.Enums;

namespace JwtDecoratorCaching.Api.Models
{
    public class JwtToken
    {
        public string Token { get; set; }
        public DataSource Source { get; set; }
    }
}
