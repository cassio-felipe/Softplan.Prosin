using System.Threading.Tasks;
using CalculaJurosAPI.Domain;
using CalculaJurosAPI.Infra;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IJurosApi _jurosApi;

        public CalculaJurosController(IJurosApi jurosApi)
        {
            _jurosApi = jurosApi;
        }
        
        [HttpGet]
        public async Task<ActionResult<decimal>> CalculaJuros(decimal valorInicial, int meses)
        {
            var taxajurosApi = await _jurosApi.GetJuros();
            var calculaJuros = new CalculaJuros();
            return Ok(calculaJuros.Calcular(valorInicial, taxajurosApi, meses));
        }
    }
}