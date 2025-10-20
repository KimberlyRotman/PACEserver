using Models.Enums;

namespace Models;

public class TarefaAluno
{
    public Guid Id { get; set; }
    public Guid TarefaId { get; set; }
    public Tarefa Tarefa { get; set; }
    public Guid AlunoId { get; set; }
    public Aluno Aluno { get; set; }
    public Guid? EquipeId { get; set; }
    public Equipe? Equipe { get; set; }
    public Kanbam Kambam { get; set; } = 0;
    public bool Enviado { get; set; } = false;
    public DateTime? DataCadastro { get; set; } = DateTime.Now;

    public TarefaAluno()
    {
        Id = Guid.NewGuid();
        DataCadastro = DateTime.UtcNow;
    }
}
