namespace Models;

public class Aluno
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool Admin { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public ICollection<Matricula>? Matriculas { get; set; } = new List<Matricula>();

    public Aluno()
    {
        DataCriacao = DateTime.UtcNow;
        Id = Guid.NewGuid();
    }
}

