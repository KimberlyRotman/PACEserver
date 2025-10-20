namespace Models.Abstractions;

internal interface IProfessor
    : Ids
{
    public Guid Id { get; set; }
    string Nome { get; set; }
    string Email { get; set; }
}
