using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameQuarkAPI.Controllers
{
  [Authorize(Roles = "Admin")]
  [ApiController]
  [Route("[controller]")]
  public class AdminController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("This is the admin dashboard.");
    }
  }
}
