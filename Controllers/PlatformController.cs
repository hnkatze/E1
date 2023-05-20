using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformController : ControllerBase
    {
        IPlatformService PlatformService;
        public PlatformController(IPlatformService _PlatformService)
        {
            PlatformService = _PlatformService;
        }

        [HttpPost]
        public async Task<IActionResult> postPlatform([FromBody] Platform newPlatform)
        {
            await PlatformService.Create(newPlatform);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(PlatformService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Platform updPlatform)
        {
            await PlatformService.Update(id, updPlatform);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await PlatformService.Delete(id);
            return Ok();
        }
    }
}