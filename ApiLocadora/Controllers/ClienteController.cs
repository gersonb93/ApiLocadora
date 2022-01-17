using ApiLocadora.Business;
using ApiLocadora.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiLocadora.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;

        // Declaration of the service used
        private IClienteBusiness _clienteBusiness;

        // Injection of an instance of IPersonService
        // when creating an instance of PersonController
        public ClienteController(ILogger<ClienteController> logger, IClienteBusiness clienteBusiness)
        {
            _logger = logger;
            _clienteBusiness = clienteBusiness;
        }
        // Maps GET requests to https://localhost:{port}/api/pessoa
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clienteBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/pessoa/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var cliente = _clienteBusiness.FindByID(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        // Maps POST requests to https://localhost:{port}/api/pessoa/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            if (cliente == null) return BadRequest();
            return Ok(_clienteBusiness.Create(cliente));
        }
        // Maps PUT requests to https://localhost:{port}/api/pessoa/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            if (cliente == null) return BadRequest();
            return Ok(_clienteBusiness.Update(cliente));
        }

        // Maps DELETE requests to https://localhost:{port}/api/pessoa/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _clienteBusiness.Delete(id);
            return NoContent();
        }

    }
}
