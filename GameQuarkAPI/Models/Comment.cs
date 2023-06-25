using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameQuarkAPI.Models
{
  public class Comment
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Content { get; set; }

    [Required]
    [ForeignKey("Article")]
    public int ArticleId { get; set; }

    [Required]
    [ForeignKey("ApplicationUser")]
    public string? UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Article? Article { get; set; }
    public virtual ApplicationUser? User { get; set; }
  }
}
