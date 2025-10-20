namespace Models;

public class Equipe
{
    public Guid Id { get; set; }
    public Guid TarefaId { get; set; }
    public Tarefa Tarefa { get; set; } = new Tarefa();
    public List<Aluno> Alunos { get; set; } = new();
    public DateTime DataCriacao { get; set; } = DateTime.Now;

    public Equipe()
    {
        Id = Guid.NewGuid();
    }
}