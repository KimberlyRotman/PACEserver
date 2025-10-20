namespace Models;

public class Professor
{
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public Professor()
    {
        Id = Guid.NewGuid();
    }
}
