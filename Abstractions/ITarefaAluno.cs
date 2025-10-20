using Models.Enums;

namespace Models.Abstractions;

internal class ITarefaAluno
    : Ids
{
    public Guid Id { get; set; }
    ITarefa Tarefa { get; set; }
    IAluno Aluno { get; set; }
    IEquipe Equipe { get; set; }
    Kanbam Kambam { get; set; }
    bool Enviado { get; set; }
    DateTime? DataCadastro { get; set; }
}