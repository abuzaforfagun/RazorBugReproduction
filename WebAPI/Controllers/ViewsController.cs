using Microsoft.AspNetCore.Mvc;
using Domain;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ViewsController : ControllerBase
    {
        private readonly IRazorHelper _helper;

        public ViewsController(IRazorHelper helper)
        {
            _helper = helper;
        }

        [HttpGet]
        public IActionResult ProduceException()
        {
            _helper.FindView();

            return Ok();
        }
    }
}
