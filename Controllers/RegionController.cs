using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionController : ControllerBase
    {
        IRegionService RegionService;
        public RegionController(IRegionService _RegionService)
        {
            RegionService = _RegionService;
        }

        [HttpPost]
        public async Task<IActionResult> postCountry([FromBody] Region newRegion)
        {
            await RegionService.Create(newRegion);           
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(RegionService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Region updRegion)
        {
            await RegionService.Update(id, updRegion);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await RegionService.Delete(id);
            return Ok();
        }
    }
}