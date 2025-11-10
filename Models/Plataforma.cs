using System.ComponentModel.DataAnnotations;

namespace Models;

public class Plataforma
{
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
