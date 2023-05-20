using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Region_SalesController : ControllerBase
    {
        IRegionSaService RegionSaService;
        public Region_SalesController(IRegionSaService _RegionSaService)
        {
            RegionSaService = _RegionSaService;
        }

        [HttpPost]
        public async Task<IActionResult> postRegionSa([FromBody]  Region_Sale newRegionSa)
        {
            await RegionSaService.Create(newRegionSa);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(RegionSaService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody]  Region_Sale updRegionSa)
        {
            await RegionSaService.Update(id, updRegionSa);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await RegionSaService.Delete(id);
            return Ok();
        }
    }
}