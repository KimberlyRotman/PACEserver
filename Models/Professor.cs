using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table ("Professores")]
public class Professor
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public int Codigo { get; set; }

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
