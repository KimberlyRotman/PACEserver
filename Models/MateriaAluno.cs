using System.ComponentModel.DataAnnotations;

namespace Models;

public class MateriaAluno
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid AlunoId { get; set; }
    public Aluno Aluno { get; set; }

    public Guid MateriaId { get; set; }
    public Materia Materia { get; set; }
}

