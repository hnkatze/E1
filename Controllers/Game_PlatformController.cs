using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Game_PlatformController : ControllerBase
    {
        IGamePService GamePService;
        public Game_PlatformController(IGamePService _GamePService)
        {
            GamePService = _GamePService;
        }

        [HttpPost]
        public async Task<IActionResult> postPlatform([FromBody] Game_Platform newGameP)
        {
            await GamePService.Create(newGameP);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GamePService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Game_Platform updGameP)
        {
            await GamePService.Update(id, updGameP);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await GamePService.Delete(id);
            return Ok();
        }
    }
}