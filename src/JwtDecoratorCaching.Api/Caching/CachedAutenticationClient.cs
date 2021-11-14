using JwtDecoratorCaching.Api.Enums;
using JwtDecoratorCaching.Api.HttpClients;
using JwtDecoratorCaching.Api.Models;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;

namespace JwtDecoratorCaching.Api.Caching
{
    public class CachedAutenticacaoClient : IAutenticacaoClient
    {
        private const string JWTKEY = "JwtToken";
        private readonly IAutenticacaoClient _autenticacaoClient;
        private readonly IMemoryCache _memoryCache;

        public CachedAutenticacaoClient(
            IAutenticacaoClient autenticacaoClient,
            IMemoryCache memoryCache)
        {
            _autenticacaoClient = autenticacaoClient;
            _memoryCache = memoryCache;
        }

        public async Task<JwtToken> GetJwt()
        {
            var isFromCache = _memoryCache.TryGetValue(JWTKEY, out JwtToken item);
            if (!isFromCache)
            {
                item = await _autenticacaoClient.GetJwt();
            }
            else
            {
                item.Source = DataSource.Cache;
            }

            _memoryCache.Set(JWTKEY, item);
            return item;
        }
    }
}
