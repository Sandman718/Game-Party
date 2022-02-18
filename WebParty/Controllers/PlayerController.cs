using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebParty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        IBRepo _bl;
        public PlayerController(IBRepo bl)
        {
            _bl = bl;
        }
        // GET: api/<PlayerController>
        [HttpGet]
        public List<Player> Get()
        {
            return _bl.GetPlayers();
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlayerController>
        [HttpPost]
        public ActionResult<Player> Post([FromBody] Player playerToAdd)
        {
            _bl.addPlayer(playerToAdd);
            return Created("Sucessfully Created", playerToAdd);
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int PlayerID)
        {
            _bl.deletePlayer(PlayerID);
            return Ok();
        }
    }
}
