using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GameQuarkAPI.Controllers
{
  [Authorize(Roles = "User,Admin")]
  [ApiController]
  [Route("[controller]")]
  public class ProfileController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("This is the user profile page.");
    }
  }
}
