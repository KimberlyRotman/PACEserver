namespace Models.Abstractions;

internal interface IMatricula
    : Ids
{
    public Guid Id { get; set; }
    IAluno Aluno { get; set; }
    IMateria Materia { get; set; }
    DateTime DataInscricao { get; set; }
}