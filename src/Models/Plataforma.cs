namespace Models;

public class Plataforma
{
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public string? Link { get; set; }

    public Plataforma()
    {
        Id = Guid.NewGuid();
    }
}
