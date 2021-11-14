using JwtDecoratorCaching.Api.Models;
using Refit;
using System.Threading.Tasks;

namespace JwtDecoratorCaching.Api.ExternalServices
{
    public interface IAutenticacaoClient
    {
        [Get("/autenticacao")]
        Task<JwtToken> GetJwt();
    }
}
