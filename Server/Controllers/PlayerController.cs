using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace GameServer
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet("{id}")]
        public Player Get([FromQuery] int id)
        {
            var player = new Player() { Id = id };
            return player;
        }

        [HttpPost]
        public Player Post(Player player)
        {
            Console.WriteLine("Player added to the data base.");
            return player;
        }
    }
}