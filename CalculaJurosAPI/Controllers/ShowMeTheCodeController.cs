using CalculaJurosAPI.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult<string> ShowMeTheCode()
        {
            //verificar sobre injeção de dependencia
            var urlGitHub = new ShowMeTheCode();
            return Ok(urlGitHub.getUrlGitHub());
        }
    }
}