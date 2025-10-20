namespace Models.Abstractions;

internal interface IEquipe
    : Ids
{
    public Guid Id { get; set; }
    IList<IAluno> Membros { get; set; }
}
