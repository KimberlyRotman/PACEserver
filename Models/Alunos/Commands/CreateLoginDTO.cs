namespace Models.Alunos.Commands;

public class CreateLoginDTO
{
    public string Email { get; set; }
    public string Senha { get; set; } = string.Empty;
}
