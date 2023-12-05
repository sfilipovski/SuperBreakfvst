using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperBreakfvst.Contracts.Breakfvst;

namespace SuperBreakfvst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakfastController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {

            return Ok(request);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateBreakfast(Guid id, UpdateBreakfastRequest request)
        {

            return Ok(request);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }
    }
}
