namespace Models.Abstractions;

internal interface IMateria
    : Ids
{
    public Guid Id { get; set; }
    string Nome { get; set; }
    IProfessor Professor { get; set; }
    DateTime DataCriacao { get; set; }
    IList<ITarefa> Tarefas { get; set; }
}
