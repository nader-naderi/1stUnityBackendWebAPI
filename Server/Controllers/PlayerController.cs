using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace GameServer
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        public Player Get()
        {
            var player = new Player();
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