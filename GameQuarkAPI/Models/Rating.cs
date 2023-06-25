using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameQuarkAPI.Models
{
  public class Rating
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Article")]
    public int ArticleId { get; set; }

    [Required]
    [ForeignKey("ApplicationUser")]
    public string? UserId { get; set; }

    [Required]
    [Range(1, 5)]
    public int Value { get; set; }

    public virtual Article? Article { get; set; }
    public virtual ApplicationUser? User { get; set; }
  }
}
