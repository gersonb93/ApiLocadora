using ApiLocadora.Business;
using ApiLocadora.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiLocadora.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LocacaoController : ControllerBase
    {
        private readonly ILogger<LocacaoController> _logger;

        // Declaration of the service used
        private ILocacaoBusiness _locacaoBusiness;

        // Injection of an instance of IPersonService
        // when creating an instance of PersonController
        public LocacaoController(ILogger<LocacaoController> logger, ILocacaoBusiness locacaoBusiness)
        {
            _logger = logger;
            _locacaoBusiness = locacaoBusiness;
        }
        // Maps GET requests to https://localhost:{port}/api/filme
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_locacaoBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/filme/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var locacao = _locacaoBusiness.FindByID(id);
            if (locacao == null) return NotFound();
            return Ok(locacao);
        }

        // Maps POST requests to https://localhost:{port}/api/pessoa/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] Locacao locacao)
        {
            if (locacao == null) return BadRequest();
            return Ok(_locacaoBusiness.Create(locacao));
        }
        // Maps PUT requests to https://localhost:{port}/api/filme/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] Locacao locacao)
        {
            if (locacao == null) return BadRequest();
            return Ok(_locacaoBusiness.Update(locacao));
        }

        // Maps DELETE requests to https://localhost:{port}/api/filme/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _locacaoBusiness.Delete(id);
            return NoContent();
        }
    }
}
