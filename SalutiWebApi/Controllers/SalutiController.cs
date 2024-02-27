using Microsoft.AspNetCore.Mvc;

namespace SalutiWebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/saluti")]
    public class SalutiController : Controller
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult TestConnex()
        {
            return Ok(new InfoMsg("101", $"Saluti sono la tua prima web api csharp in Azure App Services"));
        }

        [HttpGet("{Nome}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti2(string Nome)
        {
            return Ok(new InfoMsg("101", $"Saluti {Nome}, sono la tua web api csharp in Azure App Services"));
        }

        [HttpGet("{Nome}/{version}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti3(string Nome, string version)
        {
            return Ok(new InfoMsg("101", $"Saluti {Nome}, sono la versione {version} della web api"));
        }
    }
}
