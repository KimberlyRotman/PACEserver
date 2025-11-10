using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("Plataformas")]
public class Plataforma
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? Nome { get; set; }
    public string? Link { get; set; }

    public Plataforma()
    {
        Id = Guid.NewGuid();
    }
}
