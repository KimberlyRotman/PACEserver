using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table ("Materias")]
public class Materia
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; } = string.Empty;
    public string? Codigo { get; set; }

    [ForeignKey("Professor")]
    public Guid IdProfessor { get; set; }
    public Professor Professor { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public List<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
    public List<Matricula>? Matriculas { get; set; } = new List<Matricula>();

    public Materia()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.UtcNow;
    }
}