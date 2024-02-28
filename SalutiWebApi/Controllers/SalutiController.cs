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
            return Ok(new InfoMsg("101", $"Ciao, sono la tua prima web api csharp in Azure App Services"));
        }

        [HttpGet("{Nome}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti2(string nome)
        {
            string data = DateTime.Now.ToString();
            return Ok(new InfoMsg("101", $"Ciao {nome}, sono la tua Web Api richiamata in data {data} con Azure App Services"));
        }

        [HttpGet("{Nome}/{version}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti3(string nome, string versione)
        {
            string data = DateTime.Now.ToString();
            return Ok(new InfoMsg("101", $"Ciao {nome}, sono la versione {versione} richiamata in data {data} della Web Api"));
        }
    }
}
