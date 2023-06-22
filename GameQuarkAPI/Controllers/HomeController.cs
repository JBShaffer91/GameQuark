using Microsoft.AspNetCore.Mvc;

namespace GameQuarkAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class HomeController : ControllerBase
  {
    [HttpGet]
    public IActionResult Index()
    {
      return Ok("This is the home page.");
    }
  }
}
