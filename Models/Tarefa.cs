using Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table ("Tarefas")]
public class Tarefa
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? Titulo { get; set; } = string.Empty;

    [StringLength(300)]

    public string? Descricao { get; set; }
    public int MaximoIntegrantes { get; set; } = 1;
    public TipoTarefa Tipo { get; set; }
    public bool Apresentacao { get; set; } = false;

    public DateTime? DataApresentacao { get; set; }
    public DateTime? DataEntrega { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;

    public Guid PlataformaId { get; set; }
    public Plataforma Plataforma { get; set; }

    public Materia Materia { get; set; } = new Materia();


    public Tarefa()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.UtcNow;
    }
}
