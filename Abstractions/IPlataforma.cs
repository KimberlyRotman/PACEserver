namespace Models.Abstractions;

internal interface IPlataforma
    : Ids
{
    public Guid Id { get; set; }
    string Nome { get; set; }
    string Link { get; set; }
}
