using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Alunos;

[Table ("Alunos")]
public class Aluno
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public int Codigo { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public bool Admin { get; set; }

    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

    // Navegação explícita para a tabela de junção
    public ICollection<MateriaAluno> Materias { get; set; } = new List<MateriaAluno>();

    public string SenhaHash { get; set; } = string.Empty;

}


