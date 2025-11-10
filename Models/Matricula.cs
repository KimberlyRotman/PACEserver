using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("Matriculas")]
public class Matricula
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey("Aluno")]
    public Guid AlunoId { get; set; }

    public Aluno? Aluno { get; set; }

    [ForeignKey("Materia")]
    public Guid MateriaId { get; set; }

    public Materia? Materia { get; set; }
    public DateTime DataMatricula { get; set; }

    public Matricula()
    {
        Id = Guid.NewGuid();
        DataMatricula = DateTime.UtcNow;
    }
}
