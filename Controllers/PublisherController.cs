using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublisherController : ControllerBase
    {
        IPublisherService PublisherService;
        public PublisherController(IPublisherService _PublisherService)
        {
            PublisherService = _PublisherService;
        }

        [HttpPost]
        public async Task<IActionResult> postPublisher([FromBody] Publisher newPublisher)
        {
            await PublisherService.Create(newPublisher);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(PublisherService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Publisher updPublisher)
        {
            await PublisherService.Update(id, updPublisher);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await PublisherService.Delete(id);
            return Ok();
        }
    }
}