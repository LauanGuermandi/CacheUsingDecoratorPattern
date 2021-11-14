using JwtDecoratorCaching.Api.HttpClients;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JwtDecoratorCaching.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly IAutenticacaoClient _autenticacaoClient;

        public TesteController(IAutenticacaoClient autenticacaoClient)
        {
            _autenticacaoClient = autenticacaoClient;
        }

        [HttpGet]
        public async Task<IActionResult> GetJwtToken()
        {
            var response = await _autenticacaoClient.GetJwt();
            return Ok(response);
        }
    }
}
