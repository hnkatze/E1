using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenereController : ControllerBase
    {
        IGenereService GenereService;
        public GenereController(IGenereService _GenereService)
        {
            GenereService = _GenereService;
        }

        [HttpPost]
        public async Task<IActionResult> postGenere([FromBody] Genere newGenere)
        {
            await GenereService.Create(newGenere);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GenereService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Genere updGenere)
        {
            await GenereService.Update(id, updGenere);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await GenereService.Delete(id);
            return Ok();
        }
    }
}