using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JurosAPI.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JurosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<decimal> TaxaJuros()
        {
            var taxaJuros = new TaxaJuros();
            return Ok(taxaJuros.GetJuros());
        }
    }
}