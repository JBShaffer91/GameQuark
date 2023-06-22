using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using GameQuarkAPI.Models; // Replace with the actual namespace of your RegisterModel and LoginModel

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly SignInManager<ApplicationUser> _signInManager;

  public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
  {
    _userManager = userManager;
    _signInManager = signInManager;
  }

  [HttpPost("register")]
  public async Task<IActionResult> Register(RegisterModel model)
  {
    if (ModelState.IsValid)
    {
      if (model.Email == null || model.Password == null)
      {
        return BadRequest("Email and password are required.");
      }

      var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
      var result = await _userManager.CreateAsync(user, model.Password);

      if (result.Succeeded)
      {
        await _signInManager.SignInAsync(user, isPersistent: false);
        return Ok();
      }

      return BadRequest(result.Errors);
    }

    return BadRequest(ModelState);
  }

  [HttpPost("login")]
  public async Task<IActionResult> Login(LoginModel model)
  {
    if (ModelState.IsValid)
    {
      if (model.Email == null || model.Password == null)
      {
        return BadRequest("Email and password are required.");
      }

      var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

      if (result.Succeeded)
      {
        return Ok();
      }

      if (result.IsLockedOut)
      {
        return Unauthorized("Oh no! You're locked out now.");
      }

      return Unauthorized("Invalid login attempt. Are you sure you typed the correct email/password?");
    }

    return BadRequest(ModelState);
  }
}
