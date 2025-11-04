namespace Models;

public class Aluno
{
    public Guid Id { get; set; }
    public string Nome { get; private set; }
    public string Email { get; set; } = string.Empty;
    public bool Admin { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    public ICollection<Matricula>? Matriculas { get; set; }

    public Aluno()
    {
        DataCriacao = DateTime.UtcNow;
        Id = Guid.NewGuid();
    }
}

