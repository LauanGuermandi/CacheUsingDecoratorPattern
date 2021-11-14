using JwtDecoratorCaching.Api.Models;
using Refit;
using System.Threading.Tasks;

namespace JwtDecoratorCaching.Api.HttpClients
{
    public interface IAutenticacaoClient
    {
        [Get("/autenticacao")]
        Task<JwtToken> GetJwt();
    }
}
