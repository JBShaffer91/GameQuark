#nullable disable
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GameQuarkAPI.Models;

namespace GameQuarkAPI.Data
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Comment> Comments { get; set; }

  }
}
#nullable restore