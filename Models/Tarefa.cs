using Models.Enums;

namespace Models;

public class Tarefa
{
    public Guid Id { get; set; }
    public string? Titulo { get; set; } = string.Empty;
    public string? Descricao { get; set; }
    public int MaximoIntegrantes { get; set; } = 1;
    public TipoTarefa Tipo { get; set; }
    public bool Apresentacao { get; set; } = false;

    public DateTime? DataApresentacao { get; set; }
    public DateTime? DataEntrega { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;

    public Plataforma Plataforma { get; set; }
    public Equipe? Equipe { get; set; }
    public Materia Materia { get; set; } = new Materia();


    public Tarefa()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.UtcNow;
    }
}
