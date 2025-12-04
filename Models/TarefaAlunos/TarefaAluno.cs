using Models.Alunos;
using Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.NewFolder;

[Table ("TarefasAlunos")]
public class TarefaAluno
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey("Tarefa")]
    public Guid TarefaId { get; set; }
    public Tarefa Tarefa { get; set; }

    [ForeignKey("Aluno")]
    public Guid AlunoId { get; set; }
    public Aluno Aluno { get; set; }

    [ForeignKey("Equipe")]
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
