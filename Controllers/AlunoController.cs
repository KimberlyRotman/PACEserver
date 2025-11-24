using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using PACEserver.Contexts;

namespace PACEserver.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly AppDbContext _context;

    public AlunoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable <Aluno>> GetAllAlunos()
    {
        var alunos = _context.Alunos.ToList();
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
            .ToList();

        return Ok(tarefas);
    }

    [HttpPost]
    public ActionResult Post(Aluno aluno)
    {
        _context.Alunos.Add(aluno);
        _context.SaveChanges();

        return CreatedAtAction(
            nameof(GetAlunoById),
            new { id = aluno.Id },
            aluno
        );
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
            // NÃO setar as propriedades de navegação aqui
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
