using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaJurosAPI.Domain;
using CalculaJurosAPI.Infra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IJurosAPI _jurosApi;

        //public CalculaJurosController(IJurosAPI jurosApi)
        public CalculaJurosController()
        {
            //ver sobre dependenci injection
            //_jurosApi = jurosApi;
            _jurosApi = new JurosAPI();
        }
        
        [HttpGet]
        public async Task<ActionResult<decimal>> CalculaJuros(decimal valorInicial, int meses)
        {
            //var valorInicial = Convert.ToDecimal(Request.Query["valorInicial"]);
            //var tempoMeses = Convert.ToInt32(Request.Query["meses"]);

            if ((valorInicial == 0) || (meses == 0))
            {
                return BadRequest();
            }

            var taxajurosApi = await _jurosApi.GetJuros();
            var calculaJuros = new CalculaJuros();
            
            return Ok(calculaJuros.Calcular(valorInicial, taxajurosApi, meses));
        }
    }
}