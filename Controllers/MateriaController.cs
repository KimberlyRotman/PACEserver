using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using PACEserver.Contexts;

namespace PACEserver.Controllers;

[ApiController]
[Route("[controller]")]
public class MateriaController : ControllerBase
{
    private readonly AppDbContext _context;

    public MateriaController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Materia>> GetAllMaterias()
    {
        var materias = _context.Materias.AsNoTracking().ToList();
        if (materias is null)
        {
            return NotFound("Materias não encontrados");
        }
        return Ok(materias);
    }

    [HttpGet("{id:Guid}")]

    public ActionResult<Materia> GetMateriaById(Guid id)
    {
        var materia = _context.Materias.Find(id);
        if (materia is null)
        {
            return NotFound("Materia não encontrada");
        }
        return Ok(materia);
    }

    [HttpGet("{id:Guid}/tarefas")]
    public ActionResult<IEnumerable<Tarefa>> GetTarefasDaMateria(Guid id)
    {
        var materia = _context.Materias
            .Include(m => m.Tarefas)
            .FirstOrDefault(m => m.Id == id);

        if (materia is null)
            return NotFound("Matéria não encontrada");

        return Ok(materia.Tarefas);
    }


    [HttpGet("{id:Guid}/alunos")]
    public ActionResult<IEnumerable<Aluno>> GetAlunosDaMateria(Guid id)
    {
        var materiaExiste = _context.Materias.Any(m => m.Id == id);
        if (!materiaExiste)
            return NotFound("Matéria não encontrada");

        var alunos = _context.MateriaAlunos
            .Where(ma => ma.MateriaId == id)
            .Include(ma => ma.Aluno)
            .Select(ma => ma.Aluno)
            .AsNoTracking()
            .ToList();

        return Ok(alunos);
    }

    [HttpPost]
    public ActionResult Post(Materia materia)
    {
        _context.Materias.Add(materia);
        _context.SaveChanges();

        return CreatedAtAction(
            nameof(GetMateriaById),
            new { id = materia.Id },
            materia
        );
    }

    [HttpPut]
    public ActionResult Put(Materia materia)
    {
        if (materia is null)
        {
            return BadRequest("Dados inválidos");
        }
        var materiaExistente = _context.Materias.Find(materia.Id);
        if (materiaExistente is null)
        {
            return NotFound("Materia não encontrada");
        }
        _context.Materias.Update(materia);
        _context.SaveChanges();
        return Ok(materia);
    }

    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id) {
        var materia = _context.Materias.Find(id);
        if (materia is null) {
            return NotFound("Materia não encontrada");
        }
        _context.Materias.Remove(materia);
        _context.SaveChanges();
        return Ok(materia);
    }

    [HttpDelete]
    public ActionResult DeleteAll()
        {
        var materias = _context.Materias.ToList();
        if (materias is null || materias.Count == 0) {
            return NotFound("Nenhuma materia encontrada");
        }
        _context.Materias.RemoveRange(materias);
        _context.SaveChanges();
        return Ok("Todas as materias foram deletadas");
    }

}
