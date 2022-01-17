using ApiLocadora.Business;
using ApiLocadora.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiLocadora.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class FilmeController : ControllerBase
    {
        private readonly ILogger<FilmeController> _logger;

        // Declaration of the service used
        private IFilmeBusiness _filmeBusiness;

        // Injection of an instance of IPersonService
        // when creating an instance of PersonController
        public FilmeController(ILogger<FilmeController> logger, IFilmeBusiness filmeBusiness) 
        {
            _logger = logger;
            _filmeBusiness = filmeBusiness;
        }
        // Maps GET requests to https://localhost:{port}/api/filme
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_filmeBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/filme/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var filme = _filmeBusiness.FindByID(id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }

        // Maps POST requests to https://localhost:{port}/api/pessoa/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            if (filme == null) return BadRequest();
            return Ok(_filmeBusiness.Create(filme));
        }
        // Maps PUT requests to https://localhost:{port}/api/filme/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] Filme filme)
        {
            if (filme == null) return BadRequest();
            return Ok(_filmeBusiness.Update(filme));
        }

        // Maps DELETE requests to https://localhost:{port}/api/filme/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _filmeBusiness.Delete(id);
            return NoContent();
        }
    }
}
