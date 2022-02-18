using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebParty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        IBRepo _bl;
        public GameController(IBRepo bl)
        {
            _bl = bl;
        }
        // GET: api/<GameController>
        [HttpGet]
        public List<Game> Get()
        {
            return _bl.GetGames();
        }

        // GET api/<GameController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GameController>
        [HttpPost]
       public ActionResult<Game> Post([FromBody] Game gameToAdd)
        {
            _bl.addGame(gameToAdd);
            return Created("Sucessfully Created", gameToAdd);
        }


        // PUT api/<GameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GameController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int GameID)
        {
            _bl.deleteGame(GameID);
            return Ok();
        }
    }
}
