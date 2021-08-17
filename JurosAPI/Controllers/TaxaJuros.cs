using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JurosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJuros : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public Taxa(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        
        // GET
        public IActionResult Index()
        {
            return null;
        }
    }
}