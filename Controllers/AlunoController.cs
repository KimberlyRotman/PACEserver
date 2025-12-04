using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Alunos;
using Models.Alunos.Commands;
using Models.NewFolder;
using PACEserver.Contexts;

namespace PACEserver.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly PasswordHasher<Aluno> _passwordHasher;

    public AlunoController(AppDbContext context, PasswordHasher<Aluno> passwordHasher)
    {
        _context = context;
        _passwordHasher = passwordHasher;
    }


    [HttpGet]
    public ActionResult<IEnumerable <Aluno>> GetAllAlunos()
    {
        var alunos = _context.Alunos.AsNoTracking().ToList();
        if (alunos is null) {
            return NotFound("Alunos não encontrados");
        }
        return alunos;
    }

    [HttpGet("{id:Guid}")]
    public ActionResult<Aluno> GetAlunoById(Guid id)
    {
        var aluno = _context.Alunos.Find(id);
        if (aluno is null) {
            return NotFound("Aluno não encontrado");
        }
        return Ok(aluno);
    }

    [HttpGet("codigo/{codigo:int}")]
    public ActionResult<Aluno> GetAlunoByCodigo(int codigo)
    {
        var aluno = _context.Alunos
            .FirstOrDefault(a => a.Codigo == codigo);

        if (aluno is null)
            return NotFound("Aluno não encontrado");

        return Ok(aluno);
    }

    [HttpGet("{id:Guid}/materias")]
    public ActionResult<IEnumerable<Materia>> GetMateriasDoAluno(Guid id)
    {
        var aluno = _context.Alunos.Find(id);
        if (aluno is null)
            return NotFound("Aluno não encontrado");

        var materias = _context.MateriaAlunos
            .Where(am => am.AlunoId == id)
            .Include(am => am.Materia)
            .Select(am => am.Materia)
            .AsNoTracking()
            .ToList();

        return Ok(materias);
    }

    [HttpGet("{id:Guid}/tarefas")]
    public ActionResult<IEnumerable<Tarefa>> GetTarefasDoAluno(Guid id)
    {
        var alunoExiste = _context.Alunos.Any(a => a.Id == id);
        if (!alunoExiste)
            return NotFound("Aluno não encontrado");

        var tarefas = _context.MateriaAlunos
            .Where(am => am.AlunoId == id)
            .Include(am => am.Materia)
                .ThenInclude(m => m.Tarefas)
            .SelectMany(am => am.Materia.Tarefas)
            .AsNoTracking()
            .ToList();

        return Ok(tarefas);
    }


    [HttpPost("cadastro")]
    public ActionResult Cadastrar([FromBody] CreateAlunoDTO request)
    {
        if (request == null)
            return BadRequest("Dados inválidos");

        int maiorCodigo = _context.Alunos.Any()
            ? _context.Alunos.Max(a => a.Codigo)
            : 4999;

        int novoCodigo = maiorCodigo + 1;

        var aluno = new Aluno
        {
            Id = Guid.NewGuid(),
            Codigo = novoCodigo,
            Nome = request.Nome,
            Email = request.Email,
            Admin = false,
            DataCriacao = DateTime.UtcNow
        };

        aluno.SenhaHash = _passwordHasher.HashPassword(aluno, request.Senha);

        _context.Alunos.Add(aluno);
        _context.SaveChanges();

        return CreatedAtAction(
            nameof(GetAlunoById),
            new { id = aluno.Id },
            new { aluno.Id, aluno.Nome, aluno.Email, aluno.Codigo }
        );
    }


    [HttpPost("login")]
    public ActionResult Login([FromBody] CreateLoginDTO request)
    {
        var aluno = _context.Alunos.FirstOrDefault(a => a.Email == request.Email);
        if (aluno is null)
            return Unauthorized("Usuário não encontrado");

        var resultado = _passwordHasher.VerifyHashedPassword(
            aluno, aluno.SenhaHash, request.Senha);

        if (resultado == PasswordVerificationResult.Success)
        {
            return Ok(new { mensagem = "Login bem-sucedido", aluno.Id, aluno.Nome });
        }

        return Unauthorized("Senha incorreta");
    }




    [HttpPost("matricular")]
public ActionResult Matricular([FromBody] MatriculaRequest request)
{
    if (!_context.Alunos.Any(a => a.Id == request.AlunoId))
        return NotFound("Aluno não existe");

    if (!_context.Materias.Any(m => m.Id == request.MateriaId))
        return NotFound("Matéria não existe");

    var jaMatriculado = _context.MateriaAlunos
        .Any(ma => ma.AlunoId == request.AlunoId &&
                   ma.MateriaId == request.MateriaId);

    if (jaMatriculado)
        return Conflict("Aluno já matriculado nesta matéria");

    var matricula = new MateriaAluno
    {
        Id = Guid.NewGuid(),
        AlunoId = request.AlunoId,
        MateriaId = request.MateriaId
    };

    _context.MateriaAlunos.Add(matricula);

    var tarefasDaMateria = _context.Tarefas
        .Where(t => t.Materia.Id == request.MateriaId)
        .Select(t => t.Id)
        .ToList();

    foreach (var tarefaId in tarefasDaMateria)
    {
        _context.TarefasAlunos.Add(new TarefaAluno
        {
            Id = Guid.NewGuid(),
            TarefaId = tarefaId,
            AlunoId = request.AlunoId,
            DataCadastro = DateTime.UtcNow
        });
    }

    _context.SaveChanges();

    return Ok("Aluno matriculado com sucesso");
}


    [HttpPut]
    public ActionResult Put(Aluno aluno)
    {
        if (aluno is null)
        {
            return BadRequest("Dados inválidos");
        }

        var alunoExistente = _context.Alunos.Find(aluno.Id);
        if (alunoExistente is null)
        {
            return NotFound("Aluno não encontrado");
        }
        _context.Alunos.Update(aluno);
        _context.SaveChanges();
        return Ok(aluno);
    }

    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id)
    {
        var aluno = _context.Alunos.Find(id);
        if (aluno is null)
        {
            return NotFound("Aluno não encontrado");
        }
        _context.Alunos.Remove(aluno);
        _context.SaveChanges();
        return Ok("Aluno deletado");
    }
}
