using System.ComponentModel.DataAnnotations;

namespace Models;

public class Materia
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; } = string.Empty;
    public string? Codigo { get; set; }
    public Professor Professor { get; set; } = new Professor();
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public List<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
    public List<Matricula>? Matriculas { get; set; } = new List<Matricula>();

    public Materia()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.UtcNow;
    }
}