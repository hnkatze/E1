using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        IGameService GameService;
        public GameController(IGameService _GameService)
        {
            GameService = _GameService;
        }

        [HttpPost]
        public async Task<IActionResult> postGame([FromBody] Game newGame)
        {
            await GameService.Create(newGame);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GameService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Game updGame)
        {
            await GameService.Update(id, updGame);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await GameService.Delete(id);
            return Ok();
        }
    }
}