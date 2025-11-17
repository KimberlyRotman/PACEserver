using System.ComponentModel.DataAnnotations;

namespace Models;

public class MateriaAluno
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid AlunoId { get; set; }
    public required Aluno Aluno { get; set; }

    public Guid MateriaId { get; set; }
    public required Materia Materia { get; set; }
}

