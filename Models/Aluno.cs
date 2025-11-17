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
    public string Nome { get; private set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public bool Admin { get; set; }

    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

    // Navegação explícita para a tabela de junção
    public ICollection<MateriaAluno> Materias { get; set; } = new List<MateriaAluno>();
}


