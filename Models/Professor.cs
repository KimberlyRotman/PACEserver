using System.ComponentModel.DataAnnotations;

namespace Models;

public class Professor
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(60)]
    public string? Email { get; set; }

    public Professor()
    {
        Id = Guid.NewGuid();
    }
}
