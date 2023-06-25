using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameQuarkAPI.Data;
using GameQuarkAPI.Models;
using System.Threading.Tasks;

namespace GameQuarkAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CommentsController : ControllerBase
  {
    private readonly ApplicationDbContext _context;

    public CommentsController(ApplicationDbContext context)
    {
      _context = context;
    }

    // GET: api/Comments
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Comment>>> GetComments()
    {
      return await _context.Comments.ToListAsync();
    }

    // Other action methods...
  }
}
