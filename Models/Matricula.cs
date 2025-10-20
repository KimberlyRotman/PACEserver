namespace Models;

public class Matricula
{
    public Guid Id { get; set; }
    public Guid AlunoId { get; set; }
    public Aluno? Aluno { get; set; }
    public Guid MateriaId { get; set; }
    public Materia? Materia { get; set; }
    public DateTime DataMatricula { get; set; }

    public Matricula()
    {
        Id = Guid.NewGuid();
        DataMatricula = DateTime.UtcNow;
    }
}
