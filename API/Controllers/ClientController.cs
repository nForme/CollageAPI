using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClient _client;

        public ClientController(IClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<ActionResult<Client>> GetClients()
        {
            var result = await _client.GetClients();
            if (result == null) 
                return null;
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var result = await _client.GetClient(id);
            if (result ==null)
                return NotFound("Client not found");
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(Client client)
        {
            var newClient = await _client.CreateClient(client);
            return Ok(newClient);
        }
    }
}
