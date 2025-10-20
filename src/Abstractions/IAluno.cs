namespace Models.Abstractions;

internal interface IAluno
    : Ids
{
    public Guid Id { get; set; }
    string Nome { get; set; }
    bool Admin { get; set; }
    string Email { get; set; }
    DateTime? DataCadastro { get; set; }
}
