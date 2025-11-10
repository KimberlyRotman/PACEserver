using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table ("Equipes")]
public class Equipe
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey("Tarefa")]
    public Guid TarefaId { get; set; }

    public Tarefa Tarefa { get; set; } = new Tarefa();
    public List<Aluno> Alunos { get; set; } = new();
    public DateTime DataCriacao { get; set; } = DateTime.Now;

    public Equipe()
    {
        Id = Guid.NewGuid();
    }
}