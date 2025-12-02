namespace Models.Alunos.Commands;

public class CreateAlunoDTO
{
    public int Codigo { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}
