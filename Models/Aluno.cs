using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table ("Alunos")]
public class Aluno
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; private set; }
    public string Email { get; set; } = string.Empty;
    public bool Admin { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    public ICollection<Matricula>? Matriculas { get; set; }

    public Aluno()
    {
        DataCriacao = DateTime.UtcNow;
        Id = Guid.NewGuid();
    }
}

