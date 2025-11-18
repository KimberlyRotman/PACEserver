using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table ("Materias")]
public class Materia
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public int Codigo { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; } = string.Empty;

    [ForeignKey("Professor")]
    public Guid ProfessorId { get; set; }
    public Professor Professor { get; set; }

    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

    public List<Tarefa> Tarefas { get; set; } = new();

    public ICollection<MateriaAluno> Alunos { get; set; } = new List<MateriaAluno>();

    public Materia()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.UtcNow;
    }
}