using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameQuarkAPI.Models
{
  public class Article
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string? Title { get; set; }

    [Required]
    public string? Content { get; set; }

    [ForeignKey("Author")]
    public string? AuthorId { get; set; }

    public ApplicationUser? Author { get; set; }

    public DateTime PublishedAt { get; set; }
  }
}
